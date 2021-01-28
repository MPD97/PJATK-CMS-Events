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

            builder.Property(eve => eve.NamePl)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(eve => eve.NameEn)
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


            builder.HasMany(eve => eve.Comments)
                .WithOne(comment => comment.Event)
                .HasForeignKey(comment => comment.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Event>()
            {
                new Event()
                {
                    ID = 1,
                    NamePl = "Creamfields",
                    NameEn = "Creamfields",
                    Organisator = "London Music",
                    TicketPrice = 235.49M,
                    Latitude = 51.5074M,
                    Longitude = 0.1278M,
                    Date = new DateTime(2021, 2, 18),
                    PhotoPath = "/images/concert.jpg",
                    DescriptionPl = "Festiwal muzyki elektronicznej wywodzący się z Anglii. Obecnie festiwal rozprzestrzeniony jest na wiele krajów europejskich (Polska, Czechy, Irlandia, Hiszpania) oraz Ameryki (Chile, Argentyna, Stany Zjednoczone). Gwiazdami tego festiwalu byli m.in. The Prodigy, The Chemical Brothers, Tiesto, Pendulum, Jeff Mills, Richie Hawtin, Kosheen, Carl Cox, Felix Kröcher, Deadmau5 i wielu innych.",
                    DescriptionEn = "Festival lineup (2021): deadmau5, Carl Cox, Martin Garrix, Adam Beyer, Tiësto, Timmy Trumpet, Erix Prydz, Dimitri Vegas & Like Mike \nOne of the two or three most prestigious dance festivals on the planet, Creamfields is always full to bursting with worldwide stars. Whatever flavour of electronic music you're into, you'll find more than you could ask for at Creamfields.",
                    City = "London, United Kingdom"
                },
                new Event()
                {
                    ID = 2,
                    NamePl = "Kurs Medytacji Nowoczesnej",
                    NameEn = "Modern Meditation Course",
                    Organisator = "Polskie Stowarzyszenie Medytacji",
                    TicketPrice = 99.99M,
                    Latitude = 51.75M,
                    Longitude = 19.46667M,
                    Date = new DateTime(2021, 2, 21),
                    PhotoPath = "/images/meditation.jpg",
                    DescriptionPl = "Prosty i praktyczny kurs medytacji Odczuwaj więcej spokoju, oraz zadbaj o swoje zdrowie i równowagę emocjonalną dzięki kursowi medytacji dla początkujących. Medytacja to badanie umysłu oraz jego trening. Każda sesja medytacyjna była okazją, by zdjąć z siebie ciężar, który nosiłem w swoim ciele i umyśle. Teraz aż trudno mi uwierzyć, jak inaczej się czułem i zachowywałem kilka lat temu. Teraz jestem po prostu lepszym, szczęśliwszym człowiekiem.",
                    DescriptionEn = "Meditation has been around for a long, long time. The first literary records of meditation date back to 1500BCE. Going back to the future, a few decades ago during the seventies and sixties, mediation was in a weird spot. Due to numerous practitioners in western pop culture, meditation retreats were gaining more and more popularity. Yet, this was a two-edged sword. Meditation was mainly embraced as just another hippie-practice with little proven benefits. In the last decade, though, this notion has changed completely. Mindfulness and meditation have penetrated the mainstream more than ever. These are now seen for what they are – as legitimate practices with numerous scientifically - proven health benefits for both the mind and body.These days, due to us being connected to our work and social lives 24 / 7, we are more stressed than ever.Meditation is a simple yet effective way of becoming more centered in yourself and releasing accumulated stress.",
                    City = "Łódź, Poland"
                },
                new Event()
                {
                    ID = 3,
                    NamePl = "Rock am Ring",
                    NameEn = "Rock am Ring & Rock im Park",
                    Organisator = "German Electric Music",
                    TicketPrice = 50M,
                    Latitude = 50.3744M,
                    Longitude = 7.2808M,
                    Date = new DateTime(2021, 3, 2),
                    PhotoPath = "/images/concert2.jpeg",
                    DescriptionPl = "festiwal muzyki rockowej organizowany w okresie letnim od 1985. Do 2014 odbywał się on na torze Nürburgring w miejscowości Nürburg w Niemczech. Natomiast w 2015. festiwal został przeniesiony na lotnisko w Mendig, aby po dwóch latach wrócić z powrotem na Nürburgring. Jest to największy festiwal muzyczny w tym kraju i jeden z największych w Europie.Na dwudziestej edycji organizowanej od 2 do 4 czerwca 2006 wystąpili: Metallica, Guns N' Roses, Angels & Airwaves, Trivium, Alter Bridge, Avenged Sevenfold, Cradle of Filth, Depeche Mode, Placebo, Morrissey, Franz Ferdinand, Korn, Deftones, Editors, Die Ärzte, Nelly Furtado, Sportfreunde Stiller, Kaiser Chiefs, Tool, Jamiroquai, Dir en grey, Atreyu, In Flames, Opeth, The Bloodhound Gang, Kagerou, Danko Jones, Bullet for My Valentine, Marilyn Manson, Alice in Chains.",
                    DescriptionEn = "Festival lineup (2020): System of a Down, Green Day, Volbeat, Deftones, Billy Talent, Korn, Weezer, Broilers If rock and metal are your game, then Germany's Rock am Ring needs no introduction. Along with sister festival Rock im Park, it pulls unparalleled lineups year after year and can lay claim to being one of the best-attended weekends in the world.",
                    City = "Mendig, Germany"
                },
                new Event()
                {
                    ID = 4,
                    NamePl = "Festiwal na Wyspie Wight",
                    NameEn = "Isle of Wight Festival",
                    Organisator = "German Electric Music",
                    TicketPrice = 75M,
                    Latitude = 50.6938M,
                    Longitude = -1.3047M,
                    Date = new DateTime(2021, 3, 10),
                    PhotoPath = "/images/concert3.jpeg",
                    DescriptionPl = "Isle of Wight Festival (ang. Festiwal na Wyspie Wight) odbywał się w latach 1968–1970 pod koniec sierpnia na wyspie Wight w Anglii. Ewoluował z początkowo imprezy jednodniowej (31.08.1968) z ok. 10 tys. widzów, przez dwudniową (30–31.08.1969) z ok. 150 tys. widzów, do pięciodniowej (26–30.08.1970). Każdy ze wspomnianych koncertów był organizowany w innym miejscu. Najbardziej znaną edycją festiwalu jest ta z 1970 roku, która zgromadziła 600 tys. widzów, podziwiających takie gwiazdy jak: Jimi Hendrix (to jeden z jego ostatnich koncertów, umarł 18 września), Miles Davis, The Who, The Doors, Procol Harum, The Moody Blues, Joan Baez. Po raz kolejny odbył się po 32-letniej przerwie w 2002 roku i od tego czasu odbywa się corocznie na terenach w pobliżu Newport, największego miasta na wyspie – jest to kolejna nowa lokalizacja. Inną zmianą było przesunięcie terminu imprezy na połowę czerwca. Nowej odsłonie imprezy wiele brakuje do poprzedniej(1968–1970), zwłaszcza artystów z najwyższej światowej półki, których dotąd było niewielu: The Who w 2004, The Rolling Stones w 2006.Z roku na rok impreza gromadzi jednak coraz większą widownię(70 tys.w 2008).",
                    DescriptionEn = "The Isle of Wight Festival is a British music festival which takes place annually in Newport on the Isle of Wight, England. It was originally a counterculture event held from 1968 to 1970. The 1970 event was by far the largest of these early festivals and the unexpectedly high attendance levels led, in 1971, to Parliament adding a section to the Isle of Wight County Council Act 1971 preventing overnight open-air gatherings of more than 5,000 people on the island without a special licence from the council.The event was revived in 2002.",
                    City="Isle of Wight, United Kingdom"
                },
                new Event()
                {
                    ID = 5,
                    NamePl = "code_talks - Mikro-konferencja",
                    NameEn = "code_talks - micro-conference",
                    Organisator = "Maciej Aniserowicz",
                    TicketPrice = 0M,
                    Latitude = 50.0647M,
                    Longitude = 19.9450M,
                    Date = new DateTime(2021, 3, 15),
                    PhotoPath = "/images/tech_meetup_1.jpg",
                    DescriptionPl = "Już w grudniu kolejna edycja code_talks! To mikro-konferencja dla programistów i fascynatów programowania, organizowana przez PSI Polska. Widzimy się 5 grudnia. \n  Zastosowanie generatywnych technik uczenia maszynowego do przemysłowych szeregów czasowych \n Live coding, który pokazuje, jak przy pomocy narzędzi JMC, JMH, flight recorder, asyncprofiler i flamegraphs, optymalizować kod w Javie. ",
                    DescriptionEn = "Meditation has been around for a long, long time. The first literary records of meditation date back to 1500BCE. Going back to the future, a few decades ago during the seventies and sixties, mediation was in a weird spot. Due to numerous practitioners in western pop culture, meditation retreats were gaining more and more popularity. Yet, this was a two-edged sword. Meditation was mainly embraced as just another hippie-practice with little proven benefits. In the last decade, though, this notion has changed completely. Mindfulness and meditation have penetrated the mainstream more than ever. These are now seen for what they are – as legitimate practices with numerous scientifically - proven health benefits for both the mind and body.These days, due to us being connected to our work and social lives 24 / 7, we are more stressed than ever.Meditation is a simple yet effective way of becoming more centered in yourself and releasing accumulated stress.",
                    EventType = EventType.Meeting,
                    City = "Kraków, Poland"
                },
                 new Event()
                {
                    ID = 6,
                    NamePl = "Wykład \'Sekretne życie obrazów\'",
                    NameEn = "Lecture \'The Secret Life of Images\'",
                    Organisator = "Muzeum Wojska Polskiego",
                    TicketPrice = 10M,
                    Latitude = 52.2297M,
                    Longitude = 21.0122M,
                    Date = new DateTime(2021, 4, 2),
                    PhotoPath = "/images/meeting_art_1.PNG",
                    DescriptionPl = "„Sekretne życie obrazów” to muzyczny collage złożony z fragmentów oper barokowych Monteverdiego, Haendla i Vivaldiego. Arie z oper „Orlando”, „Ariodante” czy „Alcina”, czyli „muzyczne obrazy” wyjęte z większej całości, stają się kanwą opowieści osnutych wokół scen uchwyconych w dziełach mistrzów barokowego malarstwa.",
                    DescriptionEn = "„The Secret Life of Images” is a musical collage composed of excerpts from Baroque operas by Monteverdi, Handel and Vivaldi. Arias from the operas „Orlando”, „Ariodante” or „Alcina”, or „musical images” taken from a larger whole, become the basis of stories wrapped around scenes captured in the works of baroque painting masters.",
                    EventType = EventType.Meeting,
                    City = "Warszawa, Poland"
                },
                  new Event()
                {
                    ID = 7,
                    NamePl = "Wystawa \'Afrykańskie wyprawy, azjatyckie drogi\'",
                    NameEn ="Exhibition\" African expeditions, Asian roads\"",
                    Organisator = "Muzeum Geologiczne Warszawa",
                    TicketPrice = 15M,
                    Latitude = 52.2297M,
                    Longitude = 21.0122M,
                    Date = new DateTime(2021, 4, 22),
                    PhotoPath = "/images/exhibition_1.jpg",
                    DescriptionPl = "Dwa rozległe kontynenty, bogactwo różnorodnych tradycji oraz kultury materialnej i duchowej. Jedna z nowo otwartych galerii poświęcona jest Azji, druga, im. Leopolda Janikowskiego, Afryce. W obu możemy odnaleźć unikatowe eksponaty, ale także poznać historie dzięki multimedialnym stanowiskom.",
                    DescriptionEn = "Two vast continents, the wealth of various traditions and material and spiritual culture. One of the newly opened galleries is dedicated to Asia, the other - to them. Leopold Janikowski, Africa. In both, we can find unique exhibits, but also learn about the stories thanks to the multimedia stands.",
                    EventType = EventType.Meeting,
                    City = "Warszawa, Poland"
                },
                new Event
                {
                    ID = 8,
                    City = "Warszawa, Poland",
                    Date = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "Produced entirely by Sevdaliza together with long-time collaborator Mucky, the 15 track album is the long awaited follow-up to her critically acclaimed 2017 debut album, ‘ISON.’ ‘Shabrang’ sees Sevdaliza take back her power from years of physical and emotional turbulence, which is embodied in the black eye on the album cover. It chronicles her journey of self-discovery, self-love and finding peace amongst all of the chaos in the world serving as a catalyst for empowerment and healing through the collective consciousness. The album further cements Sevdaliza as one of today’s most essential artists as she continues to push the boundaries of sound creating a style completely unique to her lined with elements of alternative electronic, indie, trip-hop, alternative R&B and the avant-garde.                             In celebration, Sevdaliza will be doing a special performance on August 31 at the Royal Theatre in The Hague in the Netherlands that will live stream globally and serve as the only time she’ll take the stage in 2020. The show will feature an array of striking visual effects integrated into Sevdaliza’s gripping live set.",
                    DescriptionPl =
                        "Wyprodukowany w całości przez Sevdalizę wraz z wieloletnim współpracownikiem Mucky'm, 15-utworowy album jest długo oczekiwaną kontynuacją jej docenionego przez krytyków debiutu z 2017 roku, „ISON”. „Shabrang” pokazuje, jak Sevdaliza odzyskuje moc po latach fizycznych i emocjonalnych turbulencji, których wyrazem jest podbite oko na okładce albumu. Jest to historia jej podróży do odkrywania siebie, miłości do siebie i znajdowania pokoju pośród całego chaosu na świecie. Album dodatkowo wzmacnia pozycję Sevdalizy jako jednej z najważniejszych współczesnych artystek, która nieustannie przesuwa granice brzmienia, tworząc całkowicie unikalny dla niej styl z elementami alternatywnej elektroniki, indie, trip-hopu, alternatywnego R&B i awangardy. Aby uczcić premierę albumu, Sevdaliza zagra 31 sierpnia w Royal Theatre w Hadze w Holandii specjalny spektakl, który będzie transmitowany na żywo na całym świecie i będzie jedynym jej scenicznym występem w 2020 roku. Uderzające efekty wizualne zintegrowane będą z porywającym muzycznym występem Sevdalizy. ",
                    EventType = EventType.Concert,
                    Latitude = 52.211588m,
                    Longitude = 21.0080273m,
                    NamePl = "Sevdaliza",
                    NameEn = "Sevdaliza",
                    Organisator = "Klub Stodoła",
                    PhotoPath = "/images/sevdaliza.jpg",
                    TicketPrice = 105m
                },
                new Event
                {
                    ID = 9,
                    City = "Warszawa, Poland",
                    Date = new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "Neck Deep is a Welsh pop-punk band from Wrexham, formed in 2012. Neck Deep's career began with the publication of the song 'What Did You Expect?', which quickly gained recognition from listeners and critics. Following this, the band released two EPs: Rain in July (2012) and A History of Bad Decisions (2013), and then signed a contract with the Hopeless label. urrently, the band has released four studio albums, and the last of them, 'All Distortions Are Intentional', was released in July this year and entered the Official UK Album Chart at number four.",
                    DescriptionPl =
                        "Neck Deep to walijski zespół pop-punkowy z Wrexham, utworzony w 2012 roku. Kariera Neck Deep rozpoczęła się od publikacji utworu  „What Did You Expect?”, który bardzo szybko zyskał uznanie słuchaczy oraz krytyków. W ślad za tym, zespół opublikował w sieci dwie EP-ki: Rain in July (2012) and A History of Bad Decisions (2013), a następnie podpisał kontrakt z wytwórnią Hopeless. Obecnie zespół ma na koncie cztery studyjne albumy, a ostatni z nich, ,, All Distortions Are Intentional’’ został wydany w lipcu tego roku i trafił na 4 miejsce na liście sprzedaży w Wielkiej Brytanii.",
                    EventType = EventType.Concert,
                    NameEn = "Neck Deep",
                    NamePl = "Neck Deep",
                    Latitude = 52.2213831m,
                    Longitude = 20.9755266m,
                    Organisator = "Klub Proxima",
                    PhotoPath = "/images/neck.jpg",
                    TicketPrice = 115m
                },
                new Event
                {
                    ID = 10,
                    City = "Warszawa, Poland",
                    Date = new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "WATERPARKS ogłaszają trasę 'SEE YOU IN THE FUTURE' i film koncertowy 'FANDOM: LIVE IN THE UK'!",
                    DescriptionPl =
                        "WATERPARKS announce the 'SEE YOU IN THE FUTURE' headline tour and the release of the 'FANDOM: LIVE IN THE UK' concert film!",
                    EventType = EventType.Concert,
                    Latitude = 52.2213831m,
                    Longitude = 20.9755266m,
                    Organisator = "Klub Proxima",
                    NamePl = "Waterparks",
                    NameEn = "Waterparks",
                    PhotoPath = "/images/waterparks.jpg",
                    TicketPrice = 79m
                },
                new Event
                {
                    ID = 11,
                    City = "Lublin, Poland",
                    Date = new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "Buy tickets for World Exhibition of Orchids, Bonsai and Succulents in Targi Lublin, Hale Targowe Expo, NETTO Arena Szczecin.",
                    DescriptionPl =
                        "Światowa Wystawa Orchidei, Bonsai i Sukulentów wiosną zawita do Lublina, Łodzi i Szczecina! Weź udział w kolorowej, niezwykle pachnącej przygodzie wśród tysięcy najwspanialszych kwiatów. Na zwiedzających czekają prawdziwe cuda natury oraz fenomenalne aranżacje z okazami pochodzącymi z blisko 40 państw. Światowa Wystawa Orchidei, Bonsai i Sukulentów bilety już dostępne. ",
                    EventType =EventType.Meeting,
                    Latitude = 51.2349941m,
                    Longitude = 22.5628468m,
                    Organisator = "http://swiatowawystawa.pl/",
                    NamePl = "Światowa Wystawa Orchidei, Bonsai i Sukulentów",
                    NameEn = "World Exhibition of Orchids, Bonsai and Succulents",
                    PhotoPath = "/images/orchid.jpg",
                    TicketPrice = 25m
                },
                new Event
                {
                    ID = 12,
                    City = "Białystok, Poland",
                    Date = new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn = "Buy tickets for Festival of Whisky in Białystok in Restauracja Kawelin.",
                    DescriptionPl =
                        "Zapraszamy na Festiwal Whisky do Białegostoku! Święto whisky odbędzie się w Restauracji Kawelin .",
                    EventType = EventType.Meeting,
                    Latitude = 53.1308333m,
                    Longitude = 23.1572557m,
                    Organisator = "Restauracja Kawelin",
                    NamePl = "Festiwal Whisky Białystok ",
                    NameEn = "Festival of Whisky in Białystok",
                    PhotoPath = "/images/whisky.jpg",
                    TicketPrice = 85m
                }, new Event
                {
                    ID = 13,
                    City = "Warszawa, Poland",
                    Date = new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "Wage War - an American metalcore band from Florida. The band includes vocalist Briton Bond, rhythm guitarist and vocalist Cody Quistad, lead guitarist Seth Blake, bassist Chris Gaylord and drummer Stephen Kluesener. Wage War released three studio albums, and the last of them titled 'Pressure' was released in 2019.Wage War previously supported such bands as August Burns Red, Chelsea Grin, I Prevail, The Amity Affliction, Northlane, Every Time I Die, For Today or Of Mice & Men",
                    DescriptionPl =
                        "Wage War - amerykański zespół metalcore pochodzący z Florydy. W skład zespołu wchodzą wokalista Briton Bond, gitarzysta rytmiczny i wokalista Cody Quistad, główny gitarzysta Seth Blake, basista Chris Gaylord oraz perkusista Stephen Kluesener. Wage War mają na koncie trzy albumy studyjne, a ostatni z nich zatytułowany ,,Pressure’’ został wydany w 2019 roku.",
                    EventType = EventType.Concert,
                    Latitude = 52.2592708m,
                    Longitude = 21.0346782m,
                    Organisator = "Hydrozagadka",
                    NamePl = "Wage War",
                    NameEn = "Wage War",
                    PhotoPath = "/images/wagewar.jpg",
                    TicketPrice = 89m
                }, new Event
                {
                    ID = 14,
                    City = "Łódź, Poland",
                    Date = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    DescriptionEn =
                        "Buy tickets for Festival of Insectivorous Plants 'Attack of the Giants' - the most exciting flower expo in the world. ",
                    DescriptionPl =
                        "Nadchodzi prawdziwy Atak Gigantów - Festiwal Roślin Owadożernych wiosną zawita do Polski! W programie największej na świecie żywej wystawy wyjątkowe pokazy, prelekcje, a przede wszystkim szaleństwo różnych atrakcji zarówno dla dorosłych, jak i dzieci. Wejdź do niesamowitej, magicznej krainy roślin owadożernych! Festiwal Roślin Owadożernych Atak Gigantów bilety już w sprzedaży.",
                    EventType = EventType.Concert,
                    Latitude = 51.7635352m,
                    Longitude = 19.457063m,
                    Organisator = "Arena Expo",
                    NamePl = "Festiwal Roślin Owadożernych 'Atak Gigantów'",
                    NameEn = "Festival of Insectivorous Plants 'Attack of the Giants'",
                    PhotoPath = "/images/owady.png",
                    TicketPrice = 15m
                }
            });
        }
    }
}
