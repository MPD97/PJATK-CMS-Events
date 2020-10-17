using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Entities
{
    public class AppIdentityUser : IdentityUser
    {

    }
    public class Event
    {
        [Column("ID")]
        public int EventId { get; set; }


        [MaxLength(250)]
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }


    }
    public class Ticket
    {
        [Column("ID")]
        public int TicketId { get; set; }

        public decimal PricePLN { get; set; }


        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
