using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreaApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 3m, "kuku" },
                    { 2, 4m, "huhuhu" },
                    { 3, 3m, "dsfsdf" },
                    { 4, 6m, "sdfdsfds" },
                    { 5, 7m, "fghfghfg" },
                    { 6, 8m, "fghfghgfh" },
                    { 7, 4m, "erterteret" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
