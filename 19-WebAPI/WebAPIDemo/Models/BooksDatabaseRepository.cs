
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebAPIDemo.Models
{
    public class BooksDatabaseRepository : IBooksInterface
    {
        private readonly BooksDB _db;
        
        public BooksDatabaseRepository(BooksDB db)
        {
            _db = db;
        }
        
        public Book CreateBook(Book newBook)
        {
            _db.Books.Add(newBook);
            _db.SaveChanges();
            return newBook;
        }

        public void DeleteBook(Book poorBook)
        {
            _db.Books.Remove(poorBook);
            _db.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _db.Books.Find(id);
        }

        public Book UpdateBook(Book updatedBook)
        {
            Book bookInDb = _db.Books.Find(updatedBook.Id);
            if (bookInDb != null)
            {
                bookInDb.Title = updatedBook.Title;
                bookInDb.Author = updatedBook.Author;
                _db.Books.Add(bookInDb);
                _db.SaveChanges();
            }
            return bookInDb;
        }
    }
}
