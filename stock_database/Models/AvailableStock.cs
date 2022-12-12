using System;
using System.Collections.Generic;

namespace stock_database.Models;

public partial class AvailableStock
{
    public int Id { get; set; }

    public string TickerSymbol { get; set; } = null!;

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public string Market { get; set; } = null!;

    public virtual Owned? Owned { get; set; }

    public virtual Watchlist? Watchlist { get; set; }
}
