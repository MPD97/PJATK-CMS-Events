using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasKey(purchase => purchase.ID);

            builder.HasMany(purchase => purchase.Tickets)
                .WithOne(ticket => ticket.Purchase)
                .HasForeignKey(ticket => ticket.PurchaseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
