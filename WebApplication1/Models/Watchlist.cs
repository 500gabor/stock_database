using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Watchlist
{
    public int Id { get; set; }

    public string TickerSymbol { get; set; } = null!;

    public virtual AvailableStock IdNavigation { get; set; } = null!;
}
