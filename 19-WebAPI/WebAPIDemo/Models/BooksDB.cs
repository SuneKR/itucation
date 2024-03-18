using Microsoft.EntityFrameworkCore;

namespace WebAPIDemo.Models
{
    public class BooksDB : DbContext
    {
        public BooksDB(DbContextOptions<BooksDB> options) : base(options) { }

        public virtual DbSet<Book> Books { get; set; }
    }
}
