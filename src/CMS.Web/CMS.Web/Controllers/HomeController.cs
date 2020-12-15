using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS.Web.Models;
using CMS.Web.Services;
using Microsoft.Extensions.Localization;

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
            ViewData["Message"] = _localizer["hello", "\'Jakieś imię\'"];
            return View(new HomeViewModel() { Events = allEvents});
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
