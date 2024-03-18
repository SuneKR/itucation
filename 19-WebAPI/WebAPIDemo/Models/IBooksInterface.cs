using WebAPIDemo.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Models
{
    public interface IBooksInterface
    {
        List<Book> GetAllBooks();
        [HttpGet] Book GetBookById(int id);
        [HttpPost] Book CreateBook(Book newBook);
        [HttpPut] Book UpdateBook(Book updatedBook);
        [HttpDelete] void DeleteBook(Book poorBook);
    }
}
