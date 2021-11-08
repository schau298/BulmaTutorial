using Microsoft.EntityFrameworkCore.Migrations;

namespace BulmaTutorial.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Food = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 40, nullable: false),
                    Brand = table.Column<string>(maxLength: 30, nullable: false),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "Brand", "Category", "Cost", "Food" },
                values: new object[,]
                {
                    { 1, "DiGiorno", "Fats", 6, "Pepperoni Pizza" },
                    { 2, "Kellog", "Cereal", 3, "Frosted Flakes" },
                    { 3, "Country Fresh", "Vegetables", 2, "Carrot Sticks" },
                    { 4, "Driscoll's", "Fruits", 4, "Strawberries" },
                    { 5, "Tyson", "Protein", 5, "Chicken Nuggets" },
                    { 6, "Frito Lay", "Fats", 3, "Doritos" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foods");
        }
    }
}
