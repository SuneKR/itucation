using Microsoft.EntityFrameworkCore;

namespace BlazorWASMDemo.Models
{
    public class KundeDB : DbContext
    {
        public KundeDB(DbContextOptions<KundeDB> options) : base(options) { }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}
