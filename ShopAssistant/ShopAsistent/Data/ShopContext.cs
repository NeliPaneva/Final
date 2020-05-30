using Microsoft.EntityFrameworkCore;
using ShopAsistent.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAsistent.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext()
        {
        }
        public ShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(Configuration.connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
