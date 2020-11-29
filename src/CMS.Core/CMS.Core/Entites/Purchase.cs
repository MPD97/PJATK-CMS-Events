using CMS.Core.Abstract;
using System.Collections.Generic;

namespace CMS.Core.Entites
{
    public class Purchase : BaseEntity
    {
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
