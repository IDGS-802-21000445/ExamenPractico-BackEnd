using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Examen_Practico.Models;

public partial class OnlineStoreContext : DbContext
{
    public OnlineStoreContext()
    {
    }

    public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Productos> onlineStore { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>(entity =>
        {
            entity.HasKey(e => e.ProductoID).HasName("PK__Producto__756A5402AAA73507");

            entity.ToTable("Productos");

            entity.Property(e => e.ProductoID).HasColumnName("ProductoID");

            entity.Property(e => e.NombreProducto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NombreProducto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Descripcion");

            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio");

            entity.Property(e => e.URLImagen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URLImagen");

            entity.Property(e => e.CategoriaID)
                .HasColumnName("CategoriaID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
