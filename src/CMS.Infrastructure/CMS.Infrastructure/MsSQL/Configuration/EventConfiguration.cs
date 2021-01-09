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
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    City = "Warszawa"
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
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    City = "Warszawa"
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
                    City = "Warszawa"
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
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    City="Warszawa"
                },
                new Event()
                {
                    ID = 5,
                    Name = "code_talks - Mikro-konferencja",
                    TicketPrice = 0M,
                    Latitude = 51.733543M,
                    Longitude = 22.893212M,
                    Date = new DateTime(2021, 12, 5),
                    PhotoPath = "/images/tech_meetup_1.jpg",
                    Description = "Już w grudniu kolejna edycja code_talks! To mikro-konferencja dla programistów i fascynatów programowania, organizowana przez PSI Polska. Widzimy się 5 grudnia. \n  Zastosowanie generatywnych technik uczenia maszynowego do przemysłowych szeregów czasowych \n Live coding, który pokazuje, jak przy pomocy narzędzi JMC, JMH, flight recorder, asyncprofiler i flamegraphs, optymalizować kod w Javie. ",
                    EventType = EventType.Meeting,
                    City = "Kraków"
                },
                 new Event()
                {
                    ID = 6,
                    Name = "Wykład 'Sekretne życie obrazów'",
                    TicketPrice = 10M,
                    Latitude = 52.23151940814265M,
                    Longitude = 21.024833080469875M,
                    Date = new DateTime(2021, 4, 2),
                    PhotoPath = "/images/meeting_art_1.PNG",
                    Description = "„Sekretne życie obrazów” to muzyczny collage złożony z fragmentów oper barokowych Monteverdiego, Haendla i Vivaldiego. Arie z oper „Orlando”, „Ariodante” czy „Alcina”, czyli „muzyczne obrazy” wyjęte z większej całości, stają się kanwą opowieści osnutych wokół scen uchwyconych w dziełach mistrzów barokowego malarstwa.",
                    EventType = EventType.Meeting,
                    City = "Warszawa"
                },
                  new Event()
                {
                    ID = 7,
                    Name = "Wystawa 'Afrykańskie wyprawy, azjatyckie drogi",
                    TicketPrice = 15M,
                    Latitude = 52.29151940814265M,
                    Longitude = 21.924833080469875M,
                    Date = new DateTime(2021, 4, 22),
                    PhotoPath = "/images/exhibition_1.jpg",
                    Description = "Dwa rozległe kontynenty, bogactwo różnorodnych tradycji oraz kultury materialnej i duchowej. Jedna z nowo otwartych galerii poświęcona jest Azji, druga, im. Leopolda Janikowskiego, Afryce. W obu możemy odnaleźć unikatowe eksponaty, ale także poznać historie dzięki multimedialnym stanowiskom.",
                    EventType = EventType.Meeting,
                    City = "Warszawa"
                }
            });
        }
    }
}
