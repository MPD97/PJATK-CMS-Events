using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Web.Services;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Event(int id)
        {
            var selectedEvent = await _eventService.GetEvent(id);
            return View(selectedEvent);
        }
    }
}
