using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class AddMoreEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                column: "City",
                value: "Warszawa");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                column: "City",
                value: "Warszawa");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                column: "City",
                value: "Warszawa");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                column: "City",
                value: "Warszawa");

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "ID", "City", "Date", "Description", "EventType", "Latitude", "Longitude", "Name", "PhotoPath", "TicketPrice" },
                values: new object[,]
                {
                    { 5, "Kraków", new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Już w grudniu kolejna edycja code_talks! To mikro-konferencja dla programistów i fascynatów programowania, organizowana przez PSI Polska. Widzimy się 5 grudnia. \n  Zastosowanie generatywnych technik uczenia maszynowego do przemysłowych szeregów czasowych \n Live coding, który pokazuje, jak przy pomocy narzędzi JMC, JMH, flight recorder, asyncprofiler i flamegraphs, optymalizować kod w Javie. ", 1, 51.733543m, 22.893212m, "code_talks - Mikro-konferencja", "/images/tech_meetup_1.jpg", 0m },
                    { 6, "Warszawa", new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "„Sekretne życie obrazów” to muzyczny collage złożony z fragmentów oper barokowych Monteverdiego, Haendla i Vivaldiego. Arie z oper „Orlando”, „Ariodante” czy „Alcina”, czyli „muzyczne obrazy” wyjęte z większej całości, stają się kanwą opowieści osnutych wokół scen uchwyconych w dziełach mistrzów barokowego malarstwa.", 1, 52.23151940814265m, 21.024833080469875m, "Wykład 'Sekretne życie obrazów'", "/images/meeting_art_1.PNG", 10m },
                    { 7, "Warszawa", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dwa rozległe kontynenty, bogactwo różnorodnych tradycji oraz kultury materialnej i duchowej. Jedna z nowo otwartych galerii poświęcona jest Azji, druga, im. Leopolda Janikowskiego, Afryce. W obu możemy odnaleźć unikatowe eksponaty, ale także poznać historie dzięki multimedialnym stanowiskom.", 1, 52.29151940814265m, 21.924833080469875m, "Wystawa 'Afrykańskie wyprawy, azjatyckie drogi", "/images/exhibition_1.jpg", 15m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                column: "City",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                column: "City",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                column: "City",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                column: "City",
                value: null);
        }
    }
}
