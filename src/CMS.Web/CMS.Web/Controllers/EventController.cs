﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Web.Models;
using CMS.Web.Requests;
using CMS.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CMS.Web.Controllers
{
    [Route("[controller]/")]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly ILogger<EventController> _logger;
        private IHostingEnvironment _environment;
        private readonly string _wwwroot;
        private readonly ICommentService _commentService;


        public EventController(IEventService eventService, ILogger<EventController> logger, IHostingEnvironment environment, ICommentService commentService)
        {
            _eventService = eventService;
            _logger = logger;
            _environment = environment;
            _wwwroot = _environment.WebRootPath;
            _commentService = commentService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Event(int id)
        {
            var selectedEvent = await _eventService.GetEvent(id);
            return View(selectedEvent);
        }
        [HttpGet("api/{id}")]
        public async Task<IActionResult> EventApi(int id)
        {
            var selectedEvent = await _eventService.GetEvent(id);
            if (selectedEvent == null)
            {
                return NotFound("Event not found!");
            }
            foreach (var comment in selectedEvent.Comments)
            {
                comment.Event = null;
            }
            return Ok(selectedEvent);
        }

        
        [Authorize(Roles = "Admin")]
        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View(new CreateEventRequest());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateEventRequest request)
        {
            if (!ModelState.IsValid || request.Photo?.Length < 0)
            {
                return View(request);
            }

            var guid = Guid.NewGuid().ToString() + ".jpg";
            var filepath = Path.Combine("images", guid);
            var filename = Path.Combine(_wwwroot, filepath);

            using (var stream = System.IO.File.Create(filename))
            {
                await request.Photo.CopyToAsync(stream);
            }
            filepath = $"/{filepath.Replace("//","/").Replace("\\","/")}";

            var eve = new Event();
            eve.NamePl = request.NamePl;
            eve.NameEn = request.NameEn;
            eve.City = request.City;
            eve.DescriptionEn = request.DescriptionPl;
            eve.DescriptionPl = request.DescriptionEn;
            eve.EventType = request.EventType;
            eve.Date = request.Date;
            eve.Latitude = request.Latitude.Value;
            eve.Longitude = request.Longitude.Value;
            eve.PhotoPath = filepath;
            eve.TicketPrice = request.TicketPrice;



            await _eventService.AddAsync(eve);

            if (await _eventService.SaveChangesAsync() <= 0)
            {
                _logger.LogError("Failed to save new Event.");
                //TODO: LOCALISATION
                ViewData["Error"] = "Failed to save new Event.";

                return View(request);
            }
            //TODO: LOCALISATION
            ViewData["Message"] = "Created successfully";

            return RedirectToAction("Index","Home");
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddComment(AddCommentModel model)
        {
            var comment = new Comment()
            {
                Date = DateTime.Now,
                EventId = model.EventId,
                Message = model.Message,
                Pseudonym = model.Pseudonym
            };
            await _commentService.AddAsync(comment);

            await _commentService.SaveChangesAsync();

            return Redirect($"/Event/{model.EventId}");
        }
    }
}
