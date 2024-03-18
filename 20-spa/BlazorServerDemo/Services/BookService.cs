using BlazorServerDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo.Services
{
    public class BookService : IBookService
    {
        private readonly BooksDbContext _db;

        public BookService(BooksDbContext db)
        {
            _db = db;
        }
        public async Task<List<Book>> GetAllBooks()
        {
            return await _db.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        }
    }
}
