using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ProductName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ProductLine = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ProductScale = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    productDescription = table.Column<string>(type: "text", nullable: false),
                    QuantityInStock = table.Column<short>(type: "smallint(6)", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MSRP = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductCode);
                    table.ForeignKey(
                        name: "FK_Products_ProductLines_ProductLine",
                        column: x => x.ProductLine,
                        principalTable: "ProductLines",
                        principalColumn: "ProductLine",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLine",
                table: "Products",
                column: "ProductLine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
