using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}