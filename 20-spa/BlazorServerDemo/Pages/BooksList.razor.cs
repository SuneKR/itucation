using BlazorServerDemo.Data;
using BlazorServerDemo.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerDemo.Pages
{
    public partial class BooksList
    {
        [Inject]
        protected IBookService BookService { get; set; }
        protected List<Book> Books { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Books = await BookService.GetAllBooks();
        }
    }
}
