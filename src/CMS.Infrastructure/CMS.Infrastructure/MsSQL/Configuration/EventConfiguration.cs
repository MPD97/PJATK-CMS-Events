using CMS.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace CMS.Infrastructure.MsSQL.Configuration
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(eve => eve.ID);

            builder.Property(eve => eve.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(eve => eve.Latitude)
                .HasPrecision(9, 6);

            builder.Property(eve => eve.Longitude)
                .HasPrecision(9, 6);

            builder.HasMany(eve => eve.Tickets)
                .WithOne(ticket => ticket.Event)
                .HasForeignKey(ticket => ticket.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Event>()
            {
                new Event()
                {
                    ID = 1,
                    Name = "Koncert XXX",
                    TicketPrice = 235.49M,
                    Latitude = 51.223543M,
                    Longitude = 22.543212M,
                    Date = new DateTime(2021, 5, 1),
                    PhotoPath = "/images/concert.jpg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Event()
                {
                    ID = 2,
                    Name = "Kurs medytacji",
                    TicketPrice = 99.99M,
                    Latitude = 51.123543M,
                    Longitude = 22.143212M,
                    Date = new DateTime(2021, 3, 20),
                    PhotoPath = "/images/meditation.jpg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Event()
                {
                    ID = 3,
                    Name = "Koncert YYY",
                    TicketPrice = 50M,
                    Latitude = 51.323543M,
                    Longitude = 22.443212M,
                    Date = new DateTime(2022, 1, 1),
                    PhotoPath = "/images/concert2.jpeg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                },
                new Event()
                {
                    ID = 4,
                    Name = "Koncert ZZZ",
                    TicketPrice = 75M,
                    Latitude = 51.723543M,
                    Longitude = 22.843212M,
                    Date = new DateTime(2021, 8, 30),
                    PhotoPath = "/images/concert3.jpeg",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            });
        }
    }
}
