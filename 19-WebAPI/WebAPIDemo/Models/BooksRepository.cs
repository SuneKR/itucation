using WebAPIDemo.Models;

namespace WebAPIDemo.Models
{
    public class BooksRepository : IBooksInterface
    {
        List<Book> books = new List<Book>
        {
            new Book {Id = 1, Title = "Dead Beat", Author = "Jim Butcher"},
            new Book {Id = 2, Title = "The Blade Itself", Author = "Joe Abercrombie"},
            new Book {Id = 3, Title = "Brave New World", Author = "Aldous Huxley"},
            new Book {Id = 4, Title = "East of Eden", Author = "John Steinbeck"},
            new Book {Id = 5, Title = "Johnny Got His Gun", Author = "Dalton Trumbo"}
        };

        public Book CreateBook(Book newBook)
        {
            books.Add(newBook);
            return newBook;
        }

        public void DeleteBook(Book poorBook)
        {
            books.Remove(poorBook);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = books.FirstOrDefault(b => b.Id == id);
            return book;
        }

        public Book UpdateBook(Book updatedBook)
        {
            Book bookInList = GetBookById(updatedBook.Id);
            bookInList.Title = updatedBook.Title;
            bookInList.Author = updatedBook.Author;
            return bookInList;
        }
    }
}
