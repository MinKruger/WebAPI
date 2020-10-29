using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Entities;

namespace WebAPI.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<HeadOffice> HeadOffice { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<HeadOffice>().ToTable("HeadOffice");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Sale>().ToTable("Sale");
            modelBuilder.Entity<Item>().ToTable("Item");

            base.OnModelCreating(modelBuilder);
        }
    }
}