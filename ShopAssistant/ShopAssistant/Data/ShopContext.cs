using Microsoft.EntityFrameworkCore;
using ShopAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAssistant.Data
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
