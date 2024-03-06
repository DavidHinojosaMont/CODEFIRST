using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class employeeNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeNumber1",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeNumber1",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeNumber1",
                table: "Employees",
                column: "EmployeeNumber1",
                principalTable: "Employees",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_EmployeeNumber1",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeNumber1",
                table: "Employees",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_EmployeeNumber1",
                table: "Employees",
                column: "EmployeeNumber1",
                principalTable: "Employees",
                principalColumn: "EmployeeNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
