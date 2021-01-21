using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infrastructure.Migrations
{
    public partial class MultilanguageDescriptioN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Event",
                newName: "DescriptionPl");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DescriptionEn", "DescriptionPl" },
                values: new object[] { "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DescriptionEn", "DescriptionPl" },
                values: new object[] { "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DescriptionEn", "DescriptionPl" },
                values: new object[] { "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DescriptionEn", "DescriptionPl" },
                values: new object[] { "ENGLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", " POLISH Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 5,
                column: "DescriptionEn",
                value: "The next edition of code_talks in December! This is a micro-conference for programmers and programming enthusiasts, organized by PSI Polska. I'll see you on December 5. \n Applying generative machine learning techniques to industrial time series \n Live coding, which shows how to use JMC, JMH, flight recorder, asyncprofiler and flamegraphs tools to optimize Java code.");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 6,
                column: "DescriptionEn",
                value: "„The Secret Life of Images” is a musical collage composed of excerpts from Baroque operas by Monteverdi, Handel and Vivaldi. Arias from the operas „Orlando”, „Ariodante” or „Alcina”, or „musical images” taken from a larger whole, become the basis of stories wrapped around scenes captured in the works of baroque painting masters.");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 7,
                column: "DescriptionEn",
                value: "Two vast continents, the wealth of various traditions and material and spiritual culture. One of the newly opened galleries is dedicated to Asia, the other - to them. Leopold Janikowski, Africa. In both, we can find unique exhibits, but also learn about the stories thanks to the multimedia stands.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "DescriptionPl",
                table: "Event",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 1,
                column: "Description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 2,
                column: "Description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 3,
                column: "Description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "ID",
                keyValue: 4,
                column: "Description",
                value: "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
        }
    }
}
