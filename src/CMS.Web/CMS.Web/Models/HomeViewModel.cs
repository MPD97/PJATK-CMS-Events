using System;
using System.Collections.Generic;
using CMS.Core.Entites;
using CMS.Web.Services;

namespace CMS.Web.Models
{
    public class HomeViewModel
    {
        private IEventService _eventService;
        public IEnumerable<Event> Events
        {
            get
            {
                return _eventService.GetEvents();
            }
        }


        public HomeViewModel(IEventService eventService)
        {
            _eventService = eventService;
        }
    }
}