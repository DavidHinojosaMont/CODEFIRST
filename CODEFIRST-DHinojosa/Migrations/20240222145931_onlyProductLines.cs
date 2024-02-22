using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class onlyProductLines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductLines",
                columns: table => new
                {
                    ProductLine = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TextDescription = table.Column<string>(type: "varchar(4000)", maxLength: 4000, nullable: false),
                    htmlDescription = table.Column<string>(type: "mediumtext", nullable: false),
                    Image = table.Column<byte[]>(type: "mediumblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLines", x => x.ProductLine);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductLines");
        }
    }
}
