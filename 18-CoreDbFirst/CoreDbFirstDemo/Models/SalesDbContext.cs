using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CoreDbFirstDemo.Models;

public partial class SalesDbContext : DbContext
{
    public SalesDbContext()
    {
    }

    public SalesDbContext(DbContextOptions<SalesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS; database=SalesDB; integrated security=true; encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Cid);

            entity.Property(e => e.Cid).HasColumnName("CID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Oid);

            entity.HasIndex(e => e.Cid, "IX_Orders_CID");

            entity.HasIndex(e => e.Pid, "IX_Orders_PID");

            entity.Property(e => e.Oid).HasColumnName("OID");
            entity.Property(e => e.Cid).HasColumnName("CID");
            entity.Property(e => e.Pid).HasColumnName("PID");

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.Orders).HasForeignKey(d => d.Cid);

            entity.HasOne(d => d.PidNavigation).WithMany(p => p.Orders).HasForeignKey(d => d.Pid);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Pid);

            entity.Property(e => e.Pid).HasColumnName("PID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
