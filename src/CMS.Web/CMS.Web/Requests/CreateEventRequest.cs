using CMS.Core.Entites;
using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Requests
{
    public class CreateEventRequest
    {

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public decimal Latitude { get; set; }

        [Required]
        public decimal Longitude { get; set; }


        [Required]
        public string PhotoPath { get; set; }


        [Required]
        public EventType EventType { get; set; }


        [Required]
        public DateTime Date { get; set; }

        public decimal TicketPrice { get; set; }

        public string Description { get; set; }
    }
}
