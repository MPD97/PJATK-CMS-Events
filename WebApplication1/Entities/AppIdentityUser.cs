using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Entities
{
    public class AppIdentityUser : IdentityUser<int>
    {

    }
    public class Event
    {
        [Column("ID")]
        public int EventId { get; set; }


        [MaxLength(250)]
        public string NamePolish { get; set; }

        [MaxLength(250)]
        public string NameEnglish { get; set; }

        public decimal Lat { get; set; }
        public decimal Lon { get; set; }

        public DateTimeOffset Date { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }
    }
    public class Ticket
    {
        [Column("ID")]
        public int TicketId { get; set; }

        public decimal? PricePLN { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
    public class Purchase
    {
        [Column("ID")]
        public int PurchaseId { get; set; }

        public PurchaseType PurchaseType { get; set; }

        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        public int AppIdentityUserId { get; set; }
        public virtual AppIdentityUser AppIdentityUser { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
    public class Person
    {
        [Column("ID")]
        public int PersonId { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string SecondName { get; set; }

        [MaxLength(150)]
        public string LastName { get; set; }

        public byte Age { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(150)]
        public string Street { get; set; }

        [MaxLength(20)]
        public string StreetNumber { get; set; }

        [MaxLength(8)]
        public string ZipCode { get; set; }

    }
    public enum PurchaseType
    {
        Reservation,
        Completed
    }
}
