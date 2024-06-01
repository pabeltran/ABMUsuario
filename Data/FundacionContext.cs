using System;
using System.Collections.Generic;
using ABM_Usuario.Models;
using Microsoft.EntityFrameworkCore;

namespace ABM_Usuario.Data;

public partial class FundacionContext : DbContext
{
    public FundacionContext()
    {
    }

    public FundacionContext(DbContextOptions<FundacionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIO__3214EC271254387D");

            entity.ToTable("USUARIO");

            entity.HasIndex(e => e.Email, "UQ__USUARIO__161CF724280890DE").IsUnique();

            entity.HasIndex(e => e.Usuario1, "UQ__USUARIO__E251F484AE6C152F").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CODIGO_POSTAL");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTRASEÑA");
            entity.Property(e => e.Direccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FechaNac)
                .HasColumnType("date")
                .HasColumnName("FECHA_NAC");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
