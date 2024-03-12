using Microsoft.EntityFrameworkCore;

namespace MigretionRoutingDemo.Models
{
    public class SalesDB : DbContext
    {
        public SalesDB(DbContextOptions<SalesDB> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CID = 1, Name = "Mark Marksen", City = "Aalborg", Phone = 74562819, Email = "MM@mail.dk" },
                new Customer { CID = 2, Name = "Freja Frejsen", City = "Esbjerg", Phone = 74579819 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { PID = 1, Name = "Gule Handker", Price = 50 },
                new Product { PID = 2, Name = "Laptop", Price = 5000 }
                );

            modelBuilder.Entity<Order>().HasData(
                new Order { OID = 1, CID = 2, PID = 1, Quantity = 2, OrderDate = DateTime.Now }
                );
        }

    }
}
