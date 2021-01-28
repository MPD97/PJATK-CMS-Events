using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class CommentsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "ID", "Date", "EventId", "Message", "Pseudonym" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "We adored your festival. What a feast of music and in such a wonderful setting.", "Alan B." },
                    { 2, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "The music was absolutely world class :))", "Mark Alabama" },
                    { 3, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "We adored your festival. What a feast of music and in such a wonderful setting.", "XY from Toronto" },
                    { 4, new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "I think it’s the best weekend of the year! Yesterday’s concert was a triumph and the playing quite exceptional.", "Paweł" },
                    { 5, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Last night was a superb example of music making at its very best. The entire evening would grace any concert hall in the country.", "Adam Nowak" },
                    { 6, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "A simply wonderful evening– the music was breath taking – I can’t believe how lucky we are to have such extraordinarily talented young musicians – it was a superb way to start the week!", "Monika" },
                    { 7, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "As we entered your glorious garden we knew we were in for a treat and what a treat! Absolute bliss - I think we were in paradise!", "Luna" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
