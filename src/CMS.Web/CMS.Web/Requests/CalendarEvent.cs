using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Areas.Identity.Pages.Calendar
{
    public class CalendarEvent
    {
        public string title { get; set; }
        public string start { get; set; }
        public int id { get; set; }
        public CalendarEvent(string title, string date, int id)
        {
            this.title = title;
            this.start = date;
            this.id= id;
        }
    }
}
