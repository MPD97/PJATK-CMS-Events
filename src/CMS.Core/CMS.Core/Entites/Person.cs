using CMS.Core.Abstract;
using System.Collections.Generic;

namespace CMS.Core.Entites
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
