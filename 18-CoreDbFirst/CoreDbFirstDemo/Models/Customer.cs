using System;
using System.Collections.Generic;

namespace CoreDbFirstDemo.Models;

public partial class Customer
{
    public int Cid { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
