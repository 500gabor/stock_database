using System;
using System.Collections.Generic;

namespace stock_database.Models;

public partial class Owned
{
    public int Id { get; set; }

    public string TickerSymbol { get; set; } = null!;

    public virtual AvailableStock IdNavigation { get; set; } = null!;
}
