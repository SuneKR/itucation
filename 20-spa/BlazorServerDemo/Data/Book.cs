using System;
using System.Collections.Generic;

namespace BlazorServerDemo.Data;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;
}
