using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class FuraadatbazisContext : DbContext
{
    public FuraadatbazisContext()
    {
    }

    public FuraadatbazisContext(DbContextOptions<FuraadatbazisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AvailableStock> AvailableStocks { get; set; }

    public virtual DbSet<Owned> Owneds { get; set; }

    public virtual DbSet<Watchlist> Watchlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=gaboradatbazisaxd.database.windows.net;Initial Catalog=furaadatbazis;User ID=hallgato;Password=Password123;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AvailableStock>(entity =>
        {
            entity.ToTable("AVAILABLE_STOCKS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Market)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MARKET");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.TickerSymbol)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TICKER_SYMBOL");
        });

        modelBuilder.Entity<Owned>(entity =>
        {
            entity.ToTable("OWNED");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TickerSymbol)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TICKER_SYMBOL");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Owned)
                .HasForeignKey<Owned>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OWNED_AVAILABLE");
        });

        modelBuilder.Entity<Watchlist>(entity =>
        {
            entity.ToTable("WATCHLIST");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TickerSymbol)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TICKER_SYMBOL");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Watchlist)
                .HasForeignKey<Watchlist>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WATCHLIST_AVAILABLE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
