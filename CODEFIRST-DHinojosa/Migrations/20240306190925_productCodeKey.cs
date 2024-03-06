using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class productCodeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderNumber",
                table: "OrderDetails",
                column: "OrderNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderNumber",
                table: "OrderDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode");
        }
    }
}
