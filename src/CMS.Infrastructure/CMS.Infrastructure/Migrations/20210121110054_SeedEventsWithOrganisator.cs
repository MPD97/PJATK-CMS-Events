using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class SeedEventsWithOrganisator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                column: "Organisator",
                value: "Stodoła");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                column: "Organisator",
                value: "Polskie Stowarzyszenie Medytacji");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                column: "Organisator",
                value: "Radio RMF MAXXX");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                column: "Organisator",
                value: "Radio Złote Przepoje Katowice");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5,
                column: "Organisator",
                value: "Maciej Aniserowicz");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6,
                column: "Organisator",
                value: "Muzeum Wojska Polskiego");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7,
                column: "Organisator",
                value: "Muzeum Geologiczne Warszawa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6,
                column: "Organisator",
                value: null);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7,
                column: "Organisator",
                value: null);
        }
    }
}
