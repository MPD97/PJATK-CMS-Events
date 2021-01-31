using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Models
{
    public class AddCommentModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Pseudonym { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(250)]
        public string Message { get; set; }

        [Required]
        public int EventId { get; set; }
    }
}
