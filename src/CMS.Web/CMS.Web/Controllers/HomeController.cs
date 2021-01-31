using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Web.Models;
using CMS.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;
using CMS.Core.Entites;
using CMS.Web.Requests;
using CMS.Web.Areas.Identity.Pages.Calendar;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CMS.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEventService _eventService;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(ILogger<HomeController> logger, IEventService eventService, IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _eventService = eventService;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            var allEvents = await _eventService.GetEvents();
            return View(new HomeViewModel() { Events = allEvents});
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Calendar()
        {
            return View();

        }
        [Route("Home/allCalendarEvents")]
        public async Task<IActionResult> CalendarEvents()
        {
            var allEvents = await _eventService.GetEvents();
            Console.WriteLine(allEvents);
            List<CalendarEvent> calendarEvents = new List<CalendarEvent>();
            allEvents.ToList().ForEach(ev => calendarEvents.Add(new CalendarEvent(ev.NamePl.ToString(), ev.Date.ToString("yyyy-MM-dd"), ev.ID)));
            Console.WriteLine("list");
            return new JsonResult(calendarEvents.ToList());
        }
        [HttpGet]
        public IActionResult Search()
        {
            var cities = GetAllCities();
            return View(new HomeViewModel() { Cities = cities});
        }
        [HttpPost]
        public async Task<IActionResult> Search(FilterEventRequest filter)
        {
            var filteredEvents = await _eventService.GetEventsByFilter(filter.Place, filter.Date, filter.EventType);
            var cities = GetAllCities();
            
            return View(new HomeViewModel() { Events = filteredEvents, Cities = cities });
        }

        private IEnumerable<SelectListItem> GetAllCities()
        {
            return _eventService.GetEvents().Result.Select(e => e.City).Distinct().OrderBy(c => c)
                .Select(c => new SelectListItem(c, c));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }
    }
}
