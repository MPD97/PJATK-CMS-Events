using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(ticket => ticket.ID);

            //builder.HasData(new List<Ticket>()
            //{
            //    new Ticket()
            //    {
            //        ID = 1,
            //        PricePLN = 139.99M,
            //        EventId = 1
                    
            //    },
            //    new Ticket()
            //     {
            //        ID = 2,
            //        PricePLN = 190M,
            //        EventId = 2
            //    },
            //    new Ticket()
            //     {
            //        ID =3,
            //        PricePLN = 249.49M,
            //        EventId = 3
            //    },
            //    new Ticket()
            //     {
            //        ID = 4,
            //        PricePLN = 35.0M,
            //        EventId = 4
            //    }
            //});
        }
    }
}
