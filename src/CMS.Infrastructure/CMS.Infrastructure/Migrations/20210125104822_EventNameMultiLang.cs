using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class EventNameMultiLang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Event",
                newName: "NamePl");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Event",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "NameEn", "NamePl", "Organisator" },
                values: new object[] { "London, United Kingdom", new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Festival lineup (2021): deadmau5, Carl Cox, Martin Garrix, Adam Beyer, Tiësto, Timmy Trumpet, Erix Prydz, Dimitri Vegas & Like Mike \nOne of the two or three most prestigious dance festivals on the planet, Creamfields is always full to bursting with worldwide stars. Whatever flavour of electronic music you're into, you'll find more than you could ask for at Creamfields.", "Festiwal muzyki elektronicznej wywodzący się z Anglii. Obecnie festiwal rozprzestrzeniony jest na wiele krajów europejskich (Polska, Czechy, Irlandia, Hiszpania) oraz Ameryki (Chile, Argentyna, Stany Zjednoczone). Gwiazdami tego festiwalu byli m.in. The Prodigy, The Chemical Brothers, Tiesto, Pendulum, Jeff Mills, Richie Hawtin, Kosheen, Carl Cox, Felix Kröcher, Deadmau5 i wielu innych.", 51.5074m, 0.1278m, "Creamfields", "Creamfields", "London Music" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "NameEn", "NamePl" },
                values: new object[] { "Łódź, Poland", new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meditation has been around for a long, long time. The first literary records of meditation date back to 1500BCE. Going back to the future, a few decades ago during the seventies and sixties, mediation was in a weird spot. Due to numerous practitioners in western pop culture, meditation retreats were gaining more and more popularity. Yet, this was a two-edged sword. Meditation was mainly embraced as just another hippie-practice with little proven benefits. In the last decade, though, this notion has changed completely. Mindfulness and meditation have penetrated the mainstream more than ever. These are now seen for what they are – as legitimate practices with numerous scientifically - proven health benefits for both the mind and body.These days, due to us being connected to our work and social lives 24 / 7, we are more stressed than ever.Meditation is a simple yet effective way of becoming more centered in yourself and releasing accumulated stress.", "Prosty i praktyczny kurs medytacji Odczuwaj więcej spokoju, oraz zadbaj o swoje zdrowie i równowagę emocjonalną dzięki kursowi medytacji dla początkujących. Medytacja to badanie umysłu oraz jego trening. Każda sesja medytacyjna była okazją, by zdjąć z siebie ciężar, który nosiłem w swoim ciele i umyśle. Teraz aż trudno mi uwierzyć, jak inaczej się czułem i zachowywałem kilka lat temu. Teraz jestem po prostu lepszym, szczęśliwszym człowiekiem.", 51.75m, 19.46667m, "Modern Meditation Course", "Kurs Medytacji Nowoczesnej" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "NameEn", "NamePl", "Organisator" },
                values: new object[] { "Mendig, Germany", new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Festival lineup (2020): System of a Down, Green Day, Volbeat, Deftones, Billy Talent, Korn, Weezer, Broilers If rock and metal are your game, then Germany's Rock am Ring needs no introduction. Along with sister festival Rock im Park, it pulls unparalleled lineups year after year and can lay claim to being one of the best-attended weekends in the world.", "festiwal muzyki rockowej organizowany w okresie letnim od 1985. Do 2014 odbywał się on na torze Nürburgring w miejscowości Nürburg w Niemczech. Natomiast w 2015. festiwal został przeniesiony na lotnisko w Mendig, aby po dwóch latach wrócić z powrotem na Nürburgring. Jest to największy festiwal muzyczny w tym kraju i jeden z największych w Europie.Na dwudziestej edycji organizowanej od 2 do 4 czerwca 2006 wystąpili: Metallica, Guns N' Roses, Angels & Airwaves, Trivium, Alter Bridge, Avenged Sevenfold, Cradle of Filth, Depeche Mode, Placebo, Morrissey, Franz Ferdinand, Korn, Deftones, Editors, Die Ärzte, Nelly Furtado, Sportfreunde Stiller, Kaiser Chiefs, Tool, Jamiroquai, Dir en grey, Atreyu, In Flames, Opeth, The Bloodhound Gang, Kagerou, Danko Jones, Bullet for My Valentine, Marilyn Manson, Alice in Chains.", 50.3744m, 7.2808m, "Rock am Ring & Rock im Park", "Rock am Ring", "German Electric Music" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "NameEn", "NamePl", "Organisator" },
                values: new object[] { "Isle of Wight, United Kingdom", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Isle of Wight Festival is a British music festival which takes place annually in Newport on the Isle of Wight, England. It was originally a counterculture event held from 1968 to 1970. The 1970 event was by far the largest of these early festivals and the unexpectedly high attendance levels led, in 1971, to Parliament adding a section to the Isle of Wight County Council Act 1971 preventing overnight open-air gatherings of more than 5,000 people on the island without a special licence from the council.The event was revived in 2002.", "Isle of Wight Festival (ang. Festiwal na Wyspie Wight) odbywał się w latach 1968–1970 pod koniec sierpnia na wyspie Wight w Anglii. Ewoluował z początkowo imprezy jednodniowej (31.08.1968) z ok. 10 tys. widzów, przez dwudniową (30–31.08.1969) z ok. 150 tys. widzów, do pięciodniowej (26–30.08.1970). Każdy ze wspomnianych koncertów był organizowany w innym miejscu. Najbardziej znaną edycją festiwalu jest ta z 1970 roku, która zgromadziła 600 tys. widzów, podziwiających takie gwiazdy jak: Jimi Hendrix (to jeden z jego ostatnich koncertów, umarł 18 września), Miles Davis, The Who, The Doors, Procol Harum, The Moody Blues, Joan Baez. Po raz kolejny odbył się po 32-letniej przerwie w 2002 roku i od tego czasu odbywa się corocznie na terenach w pobliżu Newport, największego miasta na wyspie – jest to kolejna nowa lokalizacja. Inną zmianą było przesunięcie terminu imprezy na połowę czerwca. Nowej odsłonie imprezy wiele brakuje do poprzedniej(1968–1970), zwłaszcza artystów z najwyższej światowej półki, których dotąd było niewielu: The Who w 2004, The Rolling Stones w 2006.Z roku na rok impreza gromadzi jednak coraz większą widownię(70 tys.w 2008).", 50.6938m, -1.3047m, "Isle of Wight Festival", "Festiwal na Wyspie Wight", "German Electric Music" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "City", "Date", "DescriptionEn", "Latitude", "Longitude", "NameEn" },
                values: new object[] { "Kraków, Poland", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meditation has been around for a long, long time. The first literary records of meditation date back to 1500BCE. Going back to the future, a few decades ago during the seventies and sixties, mediation was in a weird spot. Due to numerous practitioners in western pop culture, meditation retreats were gaining more and more popularity. Yet, this was a two-edged sword. Meditation was mainly embraced as just another hippie-practice with little proven benefits. In the last decade, though, this notion has changed completely. Mindfulness and meditation have penetrated the mainstream more than ever. These are now seen for what they are – as legitimate practices with numerous scientifically - proven health benefits for both the mind and body.These days, due to us being connected to our work and social lives 24 / 7, we are more stressed than ever.Meditation is a simple yet effective way of becoming more centered in yourself and releasing accumulated stress.", 50.0647m, 19.9450m, "code_talks - micro-conference" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "City", "Latitude", "Longitude", "NameEn" },
                values: new object[] { "Warszawa, Poland", 52.2297m, 21.0122m, "Lecture 'The Secret Life of Images'" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "City", "Latitude", "Longitude", "NameEn", "NamePl" },
                values: new object[] { "Warszawa, Poland", 52.2297m, 21.0122m, "Exhibition\" African expeditions, Asian roads\"", "Wystawa 'Afrykańskie wyprawy, azjatyckie drogi'" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "NamePl",
                table: "Event",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "Name", "Organisator" },
                values: new object[] { "Warszawa", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 51.223543m, 22.543212m, "Koncert XXX", "Stodoła" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "Name" },
                values: new object[] { "Warszawa", new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 51.123543m, 22.143212m, "Kurs medytacji" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "Name", "Organisator" },
                values: new object[] { "Warszawa", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 51.323543m, 22.443212m, "Koncert YYY", "Radio RMF MAXXX" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "City", "Date", "DescriptionEn", "DescriptionPl", "Latitude", "Longitude", "Name", "Organisator" },
                values: new object[] { "Warszawa", new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 51.723543m, 22.843212m, "Koncert ZZZ", "Radio Złote Przepoje Katowice" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "City", "Date", "DescriptionEn", "Latitude", "Longitude" },
                values: new object[] { "Kraków", new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The next edition of code_talks in December! This is a micro-conference for programmers and programming enthusiasts, organized by PSI Polska. I'll see you on December 5. \n Applying generative machine learning techniques to industrial time series \n Live coding, which shows how to use JMC, JMH, flight recorder, asyncprofiler and flamegraphs tools to optimize Java code.", 51.733543m, 22.893212m });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "City", "Latitude", "Longitude" },
                values: new object[] { "Warszawa", 52.23151940814265m, 21.024833080469875m });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "City", "Latitude", "Longitude", "Name" },
                values: new object[] { "Warszawa", 52.29151940814265m, 21.924833080469875m, "Wystawa 'Afrykańskie wyprawy, azjatyckie drogi" });
        }
    }
}
