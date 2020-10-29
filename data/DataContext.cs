using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<HeadOffice> HeadOffices { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<HeadOffice>().ToTable("HeadOffice").HasOne(x => x.Client).WithMany();
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Sale>().ToTable("Sale").HasOne(x => x.Item).WithMany();
            modelBuilder.Entity<Item>().ToTable("Item").HasOne(x => x.Product).WithOne();

            base.OnModelCreating(modelBuilder);
        }
    
    }
}