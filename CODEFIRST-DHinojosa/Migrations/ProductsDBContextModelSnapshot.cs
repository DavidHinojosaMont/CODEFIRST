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

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.OrderDetails", b =>
                {
                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<short>("OrderLineNumber")
                        .HasColumnType("smallint(6)");

                    b.Property<decimal>("PriceEach")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15);

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int(11)");

                    b.HasKey("OrderNumber");

                    b.HasIndex("ProductCode");

                    b.ToTable("OrderDetails");
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

            modelBuilder.Entity("CODEFIRST_DHinojosa.MODEL.OrderDetails", b =>
                {
                    b.HasOne("CODEFIRST_DHinojosa.MODEL.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductCode")
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
