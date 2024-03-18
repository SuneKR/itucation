using System;
using System.Collections.Generic;

namespace CoreDbFirstDemo.Models;

public partial class Order
{
    public int Oid { get; set; }

    public int Cid { get; set; }

    public int Pid { get; set; }

    public int Quantity { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Customer CidNavigation { get; set; } = null!;

    public virtual Product PidNavigation { get; set; } = null!;
}
