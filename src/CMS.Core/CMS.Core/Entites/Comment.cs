using System;
using CMS.Core.Abstract;

namespace CMS.Core.Entites
{
    public class Comment : BaseEntity
    {
        public string Pseudonym { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
