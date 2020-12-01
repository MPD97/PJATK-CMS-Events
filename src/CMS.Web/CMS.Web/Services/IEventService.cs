using System.Collections.Generic;
using CMS.Core.Entites;

namespace CMS.Web.Services
{
    public interface IEventService
    {
        public IEnumerable<Event> GetEvents();

        public Event GetEvent(int id);
    }
}