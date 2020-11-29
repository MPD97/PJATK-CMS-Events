using CMS.Core.Abstract;
using System.Collections.Generic;

namespace CMS.Core.Entites
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public EventType EventType { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
