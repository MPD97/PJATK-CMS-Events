using System;
using System.Collections.Generic;
using CMS.Core.Entites;
using CMS.Web.Services;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CMS.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Event> Events { get; set; }
        
        public IEnumerable<SelectListItem> Cities { get; set; }
    }
}