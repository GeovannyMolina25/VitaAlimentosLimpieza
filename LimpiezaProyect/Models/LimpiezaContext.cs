using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LimpiezaProyect.Models
{
    public partial class LimpiezaContext : DbContext
    {
        public LimpiezaContext()
        {
        }

        public LimpiezaContext(DbContextOptions<LimpiezaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LimpArea> LimpAreas { get; set; } = null!;
        public virtual DbSet<LimpFormulario> LimpFormularios { get; set; } = null!;
        public virtual DbSet<LimpFormularioActividad> LimpFormularioActividads { get; set; } = null!;
        public virtual DbSet<LimpRegistro> LimpRegistros { get; set; } = null!;
        public virtual DbSet<LimpRegistroDetalle> LimpRegistroDetalles { get; set; } = null!;

      
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<LimpArea>(entity =>
            {
                entity.HasKey(e => new { e.CodArea, e.CodEmpresa });

                entity.ToTable("LimpArea", "Prod");

                entity.HasIndex(e => e.CodRegistro, "IndLimpAreaCodRegistro")
                    .IsUnique();

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");
            });

            modelBuilder.Entity<LimpFormulario>(entity =>
            {
                entity.HasKey(e => new { e.CodFormulario, e.CodEmpresa })
                    .HasName("PK_LimpConfFormulario_1");

                entity.ToTable("LimpFormulario", "Prod");

                entity.HasIndex(e => e.CodRegistro, "IndLimpConfFormularioCodRegistro")
                    .IsUnique();

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActualizadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpFormularios)
                    .HasForeignKey(d => new { d.CodArea, d.CodEmpresa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LimpConfFormulario_LimpArea");
            });

            modelBuilder.Entity<LimpFormularioActividad>(entity =>
            {
                entity.HasKey(e => new { e.CodActividad, e.CodEmpresa, e.CodFormulario })
                    .HasName("PK_LimpConfFormularioActividad_1");

                entity.ToTable("LimpFormularioActividad", "Prod");

                entity.HasIndex(e => e.CodRegistro, "IndLimpConfFormularioActividadCodRegistro")
                    .IsUnique();

                entity.Property(e => e.CodActividad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ActualixzadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodRegistro).ValueGeneratedOnAdd();

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Decsripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpFormularioActividads)
                    .HasForeignKey(d => new { d.CodFormulario, d.CodEmpresa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LimpConfFormularioActividad_LimpConfFormulario");
            });

            modelBuilder.Entity<LimpRegistro>(entity =>
            {
                entity.HasKey(e => e.NumFormulario);

                entity.ToTable("LimpRegistro", "Prod");

                entity.Property(e => e.CodArea)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraRevisado).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraVerificacion).HasColumnType("datetime");

                entity.Property(e => e.RevisadoPor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.Turno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VerificadoPor)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpRegistros)
                    .HasForeignKey(d => new { d.CodFormulario, d.CodEmpresa })
                    .HasConstraintName("FK_LimpRegistro_LimpFormulario");
            });

            modelBuilder.Entity<LimpRegistroDetalle>(entity =>
            {
                entity.HasKey(e => e.CodRegistro);

                entity.ToTable("LimpRegistroDetalle", "Prod");

                entity.Property(e => e.CodActividad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodFormulario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.CodResponsable)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraVerificacion).HasColumnType("datetime");

                entity.Property(e => e.RevisadoPor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VerificadoPor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.NumFormularioNavigation)
                    .WithMany(p => p.LimpRegistroDetalles)
                    .HasForeignKey(d => d.NumFormulario)
                    .HasConstraintName("FK_LimpRegistroDetalle_LimpRegistro");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.LimpRegistroDetalles)
                    .HasForeignKey(d => new { d.CodActividad, d.CodEmpresa, d.CodFormulario })
                    .HasConstraintName("FK_LimpRegistroDetalle_LimpFormularioActividad");
            });

            modelBuilder.HasSequence("NumFormulario_Seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
