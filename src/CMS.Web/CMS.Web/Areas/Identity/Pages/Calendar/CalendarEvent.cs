using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Areas.Identity.Pages.Calendar
{
    public class CalendarEvent
    {
        string name;
        string start;
        public CalendarEvent(string name, string date)
        {
            this.name = name;
            this.start = date;
        }
    }
}
