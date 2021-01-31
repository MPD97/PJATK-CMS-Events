using CMS.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Models
{
    public class PurchaseModel
    {
        public int PurchaseId { get; set; }
        public virtual ICollection<TicketModel> Tickets { get; set; }
    }
    public class TicketModel
    {
        public int TicketId { get; set; }

        public decimal? PricePLN { get; set; }

        public int EventId { get; set; }
        public virtual EventModel Event { get; set; }

    }
    public class EventModel
    {
        public int EventId { get; set; }
        public string NamePl { get; set; }
        public string NameEn { get; set; }


        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public string PhotoPath { get; set; }

        public string Organisator { get; set; }

        public EventType EventType { get; set; }

        public DateTime Date { get; set; }

        public string City { get; set; }

        public decimal TicketPrice { get; set; }

        public string DescriptionPl { get; set; }
        public string DescriptionEn { get; set; }
    }
}
