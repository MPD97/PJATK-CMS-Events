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
                    Organisator = "Stodoła",
                    TicketPrice = 235.49M,
                    Latitude = 51.223543M,
                    Longitude = 22.543212M,
                    Date = new DateTime(2021, 5, 1),
                    PhotoPath = "/images/concert.jpg",
                    DescriptionPl = " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DescriptionEn = "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",                    City = "Warszawa"
                },
                new Event()
                {
                    ID = 2,
                    Name = "Kurs medytacji",
                    Organisator = "Polskie Stowarzyszenie Medytacji",
                    TicketPrice = 99.99M,
                    Latitude = 51.123543M,
                    Longitude = 22.143212M,
                    Date = new DateTime(2021, 3, 20),
                    PhotoPath = "/images/meditation.jpg",
                    DescriptionPl = " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DescriptionEn = "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",                    City = "Warszawa"
                },
                new Event()
                {
                    ID = 3,
                    Name = "Koncert YYY",
                    Organisator = "Radio RMF MAXXX",
                    TicketPrice = 50M,
                    Latitude = 51.323543M,
                    Longitude = 22.443212M,
                    Date = new DateTime(2022, 1, 1),
                    PhotoPath = "/images/concert2.jpeg",
                    DescriptionPl = " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DescriptionEn = "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",                    City = "Warszawa"
                },
                new Event()
                {
                    ID = 4,
                    Name = "Koncert ZZZ",
                    Organisator = "Radio Złote Przepoje Katowice",
                    TicketPrice = 75M,
                    Latitude = 51.723543M,
                    Longitude = 22.843212M,
                    Date = new DateTime(2021, 8, 30),
                    PhotoPath = "/images/concert3.jpeg",
                    DescriptionPl = " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    DescriptionEn = "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    City="Warszawa"
                },
                new Event()
                {
                    ID = 5,
                    Name = "code_talks - Mikro-konferencja",
                    Organisator = "Maciej Aniserowicz",
                    TicketPrice = 0M,
                    Latitude = 51.733543M,
                    Longitude = 22.893212M,
                    Date = new DateTime(2021, 12, 5),
                    PhotoPath = "/images/tech_meetup_1.jpg",
                    DescriptionPl = "Już w grudniu kolejna edycja code_talks! To mikro-konferencja dla programistów i fascynatów programowania, organizowana przez PSI Polska. Widzimy się 5 grudnia. \n  Zastosowanie generatywnych technik uczenia maszynowego do przemysłowych szeregów czasowych \n Live coding, który pokazuje, jak przy pomocy narzędzi JMC, JMH, flight recorder, asyncprofiler i flamegraphs, optymalizować kod w Javie. ",
                    DescriptionEn = "The next edition of code_talks in December! This is a micro-conference for programmers and programming enthusiasts, organized by PSI Polska. I'll see you on December 5. \n Applying generative machine learning techniques to industrial time series \n Live coding, which shows how to use JMC, JMH, flight recorder, asyncprofiler and flamegraphs tools to optimize Java code.",
                    EventType = EventType.Meeting,
                    City = "Kraków"
                },
                 new Event()
                {
                    ID = 6,
                    Name = "Wykład 'Sekretne życie obrazów'",
                    Organisator = "Muzeum Wojska Polskiego",
                    TicketPrice = 10M,
                    Latitude = 52.23151940814265M,
                    Longitude = 21.024833080469875M,
                    Date = new DateTime(2021, 4, 2),
                    PhotoPath = "/images/meeting_art_1.PNG",
                    DescriptionPl = "„Sekretne życie obrazów” to muzyczny collage złożony z fragmentów oper barokowych Monteverdiego, Haendla i Vivaldiego. Arie z oper „Orlando”, „Ariodante” czy „Alcina”, czyli „muzyczne obrazy” wyjęte z większej całości, stają się kanwą opowieści osnutych wokół scen uchwyconych w dziełach mistrzów barokowego malarstwa.",
                    DescriptionEn = "„The Secret Life of Images” is a musical collage composed of excerpts from Baroque operas by Monteverdi, Handel and Vivaldi. Arias from the operas „Orlando”, „Ariodante” or „Alcina”, or „musical images” taken from a larger whole, become the basis of stories wrapped around scenes captured in the works of baroque painting masters.",
                    EventType = EventType.Meeting,
                    City = "Warszawa"
                },
                  new Event()
                {
                    ID = 7,
                    Name = "Wystawa 'Afrykańskie wyprawy, azjatyckie drogi",
                    Organisator = "Muzeum Geologiczne Warszawa",
                    TicketPrice = 15M,
                    Latitude = 52.29151940814265M,
                    Longitude = 21.924833080469875M,
                    Date = new DateTime(2021, 4, 22),
                    PhotoPath = "/images/exhibition_1.jpg",
                    DescriptionPl = "Dwa rozległe kontynenty, bogactwo różnorodnych tradycji oraz kultury materialnej i duchowej. Jedna z nowo otwartych galerii poświęcona jest Azji, druga, im. Leopolda Janikowskiego, Afryce. W obu możemy odnaleźć unikatowe eksponaty, ale także poznać historie dzięki multimedialnym stanowiskom.",
                    DescriptionEn = "Two vast continents, the wealth of various traditions and material and spiritual culture. One of the newly opened galleries is dedicated to Asia, the other - to them. Leopold Janikowski, Africa. In both, we can find unique exhibits, but also learn about the stories thanks to the multimedia stands.",
                    EventType = EventType.Meeting,
                    City = "Warszawa"
                }
            });
        }
    }
}
