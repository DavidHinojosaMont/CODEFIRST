﻿// <auto-generated />
using System;
using CODEFIRST_DHinojosa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CODEFIRST_DHinojosa.Migrations
{
    [DbContext(typeof(ProductsDBContext))]
    partial class ProductsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Customers", b =>
                {
                    b.Property<int>("CustomerNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactFirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContactLastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("CreditLimit")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("SalesRepEmployeeNumber")
                        .HasColumnType("int(11)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CustomerNumber");

                    b.HasIndex("SalesRepEmployeeNumber");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Employees", b =>
                {
                    b.Property<int>("EmployeeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("OfficeCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("ReportsTo")
                        .HasColumnType("int(11)");

                    b.HasKey("EmployeeNumber");

                    b.HasIndex("OfficeCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Offices", b =>
                {
                    b.Property<string>("OfficeCode")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Territory")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OfficeCode");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.ProductLines", b =>
                {
                    b.Property<string>("ProductLine")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("mediumblob");

                    b.Property<string>("TextDescription")
                        .IsRequired()
                        .HasColumnType("varchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("htmlDescription")
                        .IsRequired()
                        .HasColumnType("mediumtext");

                    b.HasKey("ProductLine");

                    b.ToTable("ProductLines");
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Products", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("MSRP")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ProductLine")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ProductScale")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<short>("QuantityInStock")
                        .HasColumnType("smallint(6)");

                    b.Property<string>("productDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductCode");

                    b.HasIndex("ProductLine");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Customers", b =>
                {
                    b.HasOne("CODEFIRST_DHinojosa.MODEL.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("SalesRepEmployeeNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Employees", b =>
                {
                    b.HasOne("CODEFIRST_DHinojosa.MODEL.Offices", "Offices")
                        .WithMany()
                        .HasForeignKey("OfficeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CODEFIRST_DHinojosa.MODEL.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("ReportsTo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.Products", b =>
                {
                    b.HasOne("CODEFIRST_DHinojosa.MODEL.ProductLines", "ProductLines")
                        .WithMany()
                        .HasForeignKey("ProductLine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
