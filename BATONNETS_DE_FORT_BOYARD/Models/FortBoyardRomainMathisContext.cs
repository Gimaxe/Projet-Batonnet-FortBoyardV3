using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BATONNETS_DE_FORT_BOYARD.Models;

public partial class FortBoyardRomainMathisContext : DbContext
{
    public FortBoyardRomainMathisContext()
    {
    }

    public FortBoyardRomainMathisContext(DbContextOptions<FortBoyardRomainMathisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Compte> Comptes { get; set; }

    public virtual DbSet<Partie> Parties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=2a03:5840:111:1024:508f:fc67:4795:f4d3;User ID=sa;Password=erty64%;Database=FortBoyardRomainMathis;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compte>(entity =>
        {
            entity.HasKey(e => e.IdCompte).HasName("PK__Compte__661E3D156B565C8A");

            entity.ToTable("Compte");

            entity.HasIndex(e => e.Pseudo, "UQ__Compte__F1433CEFFC6BFE66").IsUnique();

            entity.Property(e => e.IdCompte).HasColumnName("Id_Compte");
            entity.Property(e => e.MotDePasse)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pseudo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Partie>(entity =>
        {
            entity.HasKey(e => e.IdPartie).HasName("PK__Partie__FD35BBDEF573F9A3");

            entity.ToTable("Partie");

            entity.Property(e => e.CodePartie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdCompte1).HasColumnName("idCompte1");
            entity.Property(e => e.IdCompte2).HasColumnName("idCompte2");
            entity.Property(e => e.NomDePartie)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCompte1Navigation).WithMany(p => p.PartieIdCompte1Navigations)
                .HasForeignKey(d => d.IdCompte1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__idCompte__3A81B327");

            entity.HasOne(d => d.IdCompte2Navigation).WithMany(p => p.PartieIdCompte2Navigations)
                .HasForeignKey(d => d.IdCompte2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Partie__idCompte__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
