using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Infrastructure.MsSQL;
using Microsoft.EntityFrameworkCore;

namespace CMS.Web.Services
{
    public class EventService : IEventService
    {

        private readonly ApplicationContext _context;


        public EventService(ApplicationContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Event>> GetEvents()
        {
            var allEvents = await _context.Set<Event>().ToListAsync();

            return allEvents;
        }

        public async Task<Event> GetEvent(int id)
        {
            var @event = await _context.Set<Event>().FirstOrDefaultAsync(e => e.ID == id);
            return @event;
        }

        public async Task AddAsync(Event eve)
        {
            await _context.Set<Event>().AddAsync(eve);
        }

        public void Update(Event eve)
        {
            _context.Set<Event>().Update(eve);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Event>> GetEventsByFilter(string place, DateTime? date, EventType? eventType)
        {
            var allEvents = _context.Set<Event>().AsQueryable();
            if (place != null)
            {
                allEvents = allEvents.Where(x => x.City.Contains(place));
            }

            if (date != null)
            {
                allEvents = allEvents.Where(x => x.Date >= date.Value.AddDays(-1) && x.Date <= date.Value.AddDays(1));
            }

            if (eventType != null)
            {
                allEvents = allEvents.Where(x => x.EventType == eventType);
            }

            return await allEvents.ToListAsync();
        }
    }
}