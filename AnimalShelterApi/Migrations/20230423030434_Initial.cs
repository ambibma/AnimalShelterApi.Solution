using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Note = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Name", "Note", "Sex", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, "Sparkles", "Loves Yarn a bit too much", "Female", "Cat", 17.5 },
                    { 2, "Lizzy", "Loves baking in the sun", "Male", "Iguana", 5.0 },
                    { 3, "Daisy", "Has no thoughts", "Female", "Dog", 50.5 },
                    { 4, "Hank", "Needs anger management", "male", "Chicken", 6.5 },
                    { 5, "Beatrice", "Loves eating living her best life", "Female", "Cat", 40.5 },
                    { 6, "Turty", "Loves lettuce and riding in the basket of a bicycle", "Female", "Turtle", 1.5 },
                    { 7, "Rabby", "Meows sometimes", "Male", "Rabbit", 2.0 },
                    { 8, "Hank II", "Hanks Daughter", "Female", "Chicken", 5.5 },
                    { 9, "Raphael", "Why we have a tree at our shelter we don't know but its available", "male", "Ficus", 1.5 },
                    { 10, "Napoleon", "Rumored to be the reincarnation of the French General", "male", "Mouse", 1.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
