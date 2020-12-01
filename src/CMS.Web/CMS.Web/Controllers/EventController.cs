using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Controllers
{
    [Route("[controller]/")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet("{id}")]
        public IActionResult Event(int id)
        {
            var selectedEvent = _eventService.GetEvent(id);
            return View(selectedEvent);
        }
    }
}
