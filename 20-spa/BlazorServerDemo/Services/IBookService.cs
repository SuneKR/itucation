using BlazorServerDemo.Data;

namespace BlazorServerDemo.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
    }
}
