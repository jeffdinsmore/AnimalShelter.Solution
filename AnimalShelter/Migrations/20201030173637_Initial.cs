using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace animalshelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Species = table.Column<string>(nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    AgeYears = table.Column<int>(nullable: false),
                    AgeMonths = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AgeMonths", "AgeYears", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 4, 0, "Cavapoo", "Female", "Macy", "Dog" },
                    { 2, 6, 0, "Cocker Spaniel", "Female", "Lucy", "Dog" },
                    { 3, 2, 1, "Tabby", "Female", "River", "Cat" },
                    { 4, 3, 0, "German Sheppard", "Male", "Zeus", "Dog" },
                    { 5, 3, 1, "Birman", "Male", "Dave", "Cat" },
                    { 6, 4, 1, "American Bobtail", "Male", "Carl", "Cat" },
                    { 7, 0, 1, "Bengal", "Female", "Suzie", "Cat" },
                    { 8, 2, 0, "Australian Kelpie", "Male", "Rex", "Dog" },
                    { 9, 9, 0, "Bombay", "Female", "Winnie", "Cat" },
                    { 10, 8, 0, "Burmese", "Male", "Cocoa", "Cat" },
                    { 11, 8, 3, "Apple Head Chihuahua", "Female", "Coffee", "Dog" },
                    { 12, 4, 4, "Miniature Pinscher", "Male", "Mocha", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
