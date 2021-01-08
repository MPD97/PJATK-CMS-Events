using CMS.Core.Entites;
using System;

namespace CMS.Web.Requests
{
    public class FilterEventRequest
    {
        public string Place { get; set; }

        public EventType? EventType { get; set; }

        public DateTime? Date { get; set; }
    }
}
