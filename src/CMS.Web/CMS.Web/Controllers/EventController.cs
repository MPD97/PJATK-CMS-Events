using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Web.Requests;
using CMS.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.Web.Controllers
{
    [Route("[controller]/")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ILogger<EventController> _logger;

        public EventController(IEventService eventService, ILogger<EventController> logger)
        {
            _eventService = eventService;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Event(int id)
        {
            var selectedEvent = await _eventService.GetEvent(id);
            return View(selectedEvent);
        }

        [HttpGet("Create")]
        public IActionResult Create(CreateEventRequest model)
        {
            if (model == null)
            {
                return View(new CreateEventRequest());
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> OnPostCreate(CreateEventRequest request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create", "Event", request);
            }

            var eve = new Event();
            eve.Name = request.Name;
            eve.Description = request.Description;
            eve.EventType = request.EventType;
            eve.Date = request.Date;
            eve.Latitude = request.Latitude;
            eve.Longitude = request.Longitude;

            await _eventService.AddAsync(eve);

            if (await _eventService.SaveChangesAsync() <= 0)
            {
                _logger.LogError("Failed to save new Event.");
                //TODO: LOCALISATION
                ViewData["Error"] = "Failed to save new Event.";

                return RedirectToAction("Create", "Event", request);
            }
            //TODO: LOCALISATION
            ViewData["Message"] = "Created successfully";

            return CreatedAtAction(nameof(Event), new { id = eve.ID }, eve);
        }
    }
}
