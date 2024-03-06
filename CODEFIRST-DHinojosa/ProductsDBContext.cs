using CODEFIRST_DHinojosa.MODEL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa
{
    internal class ProductsDBContext : DbContext
    {
        public ProductsDBContext()
        {

        }
        public ProductsDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=PRODUCTS;Uid=root;Pwd=\"\"");
            }
        }
        public virtual DbSet<ProductLines> ProductLines { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<OrderDetails>()
                .HasKey(o => new { o.OrderNumber, o.ProductCode });

                modelBuilder.Entity<Payments>()
                .HasKey(o => new { o.CheckNumber, o.CustomerNumber });
        }

    }
}
