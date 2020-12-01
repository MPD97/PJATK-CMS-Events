using System;
using System.Collections.Generic;
using System.Linq;
using CMS.Core.Entites;

namespace CMS.Web.Services
{
    public class EventService : IEventService
    {

        private readonly string _description =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        public IEnumerable<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event()
                {
                    ID = 0,
                    Name = "Koncert XXX",
                    Date = new DateTime(2021, 5, 1),
                    PhotoPath = "/images/concert.jpg",
                    Description = _description
                },
                new Event()
                {
                    ID = 1,
                    Name = "Kurs medytacji",
                    Date = new DateTime(2021, 3, 20),
                    PhotoPath = "/images/meditation.jpg",
                    Description = _description
                },
                new Event()
                {
                    ID = 2,
                    Name = "Koncert YYY",
                    Date = new DateTime(2022, 1, 1),
                    PhotoPath = "/images/concert2.jpeg",
                    Tickets = new List<Ticket>()
                    {
                        new Ticket()
                        {
                            PricePLN = 250
                        }
                    }
                },
                new Event()
                {
                    ID = 3,
                    Name = "Koncert ZZZ",
                    Date = new DateTime(2021, 8, 30),
                    PhotoPath = "/images/concert3.jpeg",
                    Description = _description
                }
            };
        }

        public Event GetEvent(int id)
        {
            return GetEvents().First(e => e.ID == id);
        }
    }
}