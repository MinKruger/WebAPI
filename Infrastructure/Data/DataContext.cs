using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Entities;

namespace WebAPI.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DbSet<HeadOffice> HeadOffice { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Item> Item { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

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