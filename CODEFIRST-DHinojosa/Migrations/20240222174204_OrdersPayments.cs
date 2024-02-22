using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class OrdersPayments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "date", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status = table.Column<string>(type: "varchar(15)", nullable: false),
                    Comments = table.Column<string>(type: "text", nullable: false),
                    CustomerNumber = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderNumber);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerNumber",
                        column: x => x.CustomerNumber,
                        principalTable: "Customers",
                        principalColumn: "CustomerNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    CustomerNumber = table.Column<int>(type: "int(11)", nullable: false),
                    CheckNumber = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.CustomerNumber);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerNumber",
                        column: x => x.CustomerNumber,
                        principalTable: "Customers",
                        principalColumn: "CustomerNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(type: "int(11)", nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    QuantityOrdered = table.Column<int>(type: "int(11)", nullable: false),
                    PriceEach = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    OrderLineNumber = table.Column<short>(type: "smallint(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderNumber);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderNumber",
                        column: x => x.OrderNumber,
                        principalTable: "Orders",
                        principalColumn: "OrderNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Products",
                        principalColumn: "ProductCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerNumber",
                table: "Orders",
                column: "CustomerNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
