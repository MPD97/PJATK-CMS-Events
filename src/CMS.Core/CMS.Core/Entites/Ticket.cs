using CMS.Core.Abstract;

namespace CMS.Core.Entites
{
    public class Ticket : BaseEntity
    {
        public decimal? PricePLN { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }

        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }

        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
