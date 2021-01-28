using CMS.Core.Entites;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Requests
{
    public class CreateEventRequest
    {

        [Required]
        [MinLength(5)]
        public string NamePl { get; set; }

        [Required]
        [MinLength(5)]
        public string NameEn{ get; set; }

        [Required]
        public decimal? Latitude { get; set; }

        [Required]
        public decimal? Longitude { get; set; }

        [Required]
        [MinLength(2), MaxLength(50)]
        public string City { get; set; }


        [Required]
        [MinLength(2), MaxLength(150)]
        public string Organisator { get; set; }

        [Required]
        public IFormFile Photo { get; set; }


        [Required]
        public EventType EventType { get; set; }


        [Required]
        public DateTime Date { get; set; }

        [Required]
        public decimal TicketPrice { get; set; }

        public string DescriptionPl { get; set; }
        public string DescriptionEn { get; set; }
    }
}
