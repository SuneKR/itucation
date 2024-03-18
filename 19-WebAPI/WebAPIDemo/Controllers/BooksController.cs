using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Models;
using System.ComponentModel.DataAnnotations;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //List<Book> books = new List<Book>
        //{
        //    new Book {Id = 1, Title = "Dead Beat", Author = "Jim Butcher"},
        //    new Book {Id = 2, Title = "The Blade Itself", Author = "Joe Abercrombie"},
        //    new Book {Id = 3, Title = "Brave New World", Author = "Aldous Huxley"},
        //    new Book {Id = 4, Title = "East of Eden", Author = "John Steinbeck"},
        //    new Book {Id = 5, Title = "Johnny Got His Gun", Author = "Dalton Trumbo"}
        //};

        private readonly IBooksInterface _data;
        public BooksController(IBooksInterface data)
        {
            _data = data;
        }

        [HttpGet] public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return _data.GetAllBooks();
        }

        [HttpGet("{id}")] public ActionResult<Book> GetBookById(int id)
        {
            //Book? book = books.FirstOrDefault(b => b.Id == id);
            Book book = _data.GetBookById(id);
            if (book != null) return book;
            return NotFound($"Book with id: { id } does not exist");
        }

        [HttpPost] public ActionResult<Book> CreateBook(Book newBook)
        {
            return _data.CreateBook(newBook);
        }

        [HttpDelete("{id}")] public ActionResult<Book> DeleteBookById(int id)
        {
            Book poorBook = _data.GetBookById(id);
            if (poorBook != null)
            {
                _data.DeleteBook(poorBook);
                return Ok();
            }
            return NotFound($"Book with id: { id } does not exist");
        }

        //put updates all values
        //patch only updates some values
        [HttpPut, HttpPatch] public ActionResult<Book> UpdateBook(Book bookToBeUpdated)
        {
            Book bookInRepository = _data.GetBookById(bookToBeUpdated.Id);
            if (bookInRepository != null)
            {
                _data.UpdateBook(bookToBeUpdated);
                return Ok();
            }
            return NotFound($"Book with id: { bookToBeUpdated.Id } does not exist");

        }
    }
}
