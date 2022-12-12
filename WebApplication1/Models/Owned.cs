using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Owned
{
    public int Id { get; set; }

    public string TickerSymbol { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual AvailableStock IdNavigation { get; set; } = null!;
}
