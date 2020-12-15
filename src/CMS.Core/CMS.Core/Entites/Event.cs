using System;
using CMS.Core.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace CMS.Core.Entites
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string PhotoPath { get; set; }

        public EventType EventType { get; set; }
        
        public DateTime Date { get; set; }

        public string City { get; set; }

        public decimal TicketPrice { get; set; }

        public string Description { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
