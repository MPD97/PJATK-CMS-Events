using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CMS.Core.Entites;

namespace CMS.Web.Services
{
    public interface IEventService
    {
        public Task<IEnumerable<Event>> GetEvents();

        public Task<IEnumerable<Event>> GetEventsByFilter(string place, DateTime? date, EventType? eventType);

        public Task<Event> GetEvent(int id);


        public Task AddAsync(Event eve);


        public void Update(Event eve);

        public Task<int> SaveChangesAsync();

    }
}