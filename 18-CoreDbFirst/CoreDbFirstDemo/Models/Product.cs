using System;
using System.Collections.Generic;

namespace CoreDbFirstDemo.Models;

public partial class Product
{
    public int Pid { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
