using System;
using System.Collections.Generic;
using CMS.Core.Entites;
using CMS.Web.Services;

namespace CMS.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}