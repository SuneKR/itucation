using Microsoft.EntityFrameworkCore;

namespace CoreCodeFirstDemo.Models
{
    public class LibraryDB : DbContext
    {
        public LibraryDB(DbContextOptions<LibraryDB> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book {
                    BookID = 1, Title = "Test", Author = "En Forfatter"
                });
        }

        public DbSet<Book> Books { get; set; }
    }
}
