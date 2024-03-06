using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class paymentKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "CheckNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerNumber",
                table: "Payments",
                column: "CustomerNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_CustomerNumber",
                table: "Payments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "CustomerNumber");
        }
    }
}
