﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CODEFIRST_DHinojosa.Migrations
{
    public partial class finalCompositeKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Territory = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeCode);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ProductName = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    ProductLine = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ProductScale = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ProductVendor = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeNumber = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Extension = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    OfficeCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ReportsTo = table.Column<int>(type: "int(11)", nullable: true),
                    EmployeeNumber1 = table.Column<int>(nullable: true),
                    JobTitle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeNumber);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_EmployeeNumber1",
                        column: x => x.EmployeeNumber1,
                        principalTable: "Employees",
                        principalColumn: "EmployeeNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Offices_OfficeCode",
                        column: x => x.OfficeCode,
                        principalTable: "Offices",
                        principalColumn: "OfficeCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerNumber = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContactLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    ContactFirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AddressLine2 = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    SalesRepEmployeeNumber = table.Column<int>(type: "int(11)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerNumber);
                    table.ForeignKey(
                        name: "FK_Customers_Employees_SalesRepEmployeeNumber",
                        column: x => x.SalesRepEmployeeNumber,
                        principalTable: "Employees",
                        principalColumn: "EmployeeNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "date", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "date", nullable: true),
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
                    table.PrimaryKey("PK_Payments", x => new { x.CheckNumber, x.CustomerNumber });
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
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderNumber, x.ProductCode });
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
                name: "IX_Customers_SalesRepEmployeeNumber",
                table: "Customers",
                column: "SalesRepEmployeeNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeNumber1",
                table: "Employees",
                column: "EmployeeNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_OfficeCode",
                table: "Employees",
                column: "OfficeCode");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductCode",
                table: "OrderDetails",
                column: "ProductCode");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerNumber",
                table: "Orders",
                column: "CustomerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerNumber",
                table: "Payments",
                column: "CustomerNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductLine",
                table: "Products",
                column: "ProductLine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
