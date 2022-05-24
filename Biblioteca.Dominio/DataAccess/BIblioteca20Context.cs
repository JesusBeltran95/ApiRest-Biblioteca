using System;
using Biblioteca.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Biblioteca.Dominio.DataAccess
{
    public partial class BIblioteca20Context : DbContext
    {
        public BIblioteca20Context()
        {
        }

        public BIblioteca20Context(DbContextOptions<BIblioteca20Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<InventarionLibro> InventarionLibros { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Multum> Multa { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<PersonaMultadum> PersonaMultada { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public virtual DbSet<Usuraio> Usuraios { get; set; }
        public virtual DbSet<Ventum> Venta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost; Database=BIblioteca 2.0; user id=sa; password=CBN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.ToTable("Empresa");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoraEntrada).HasColumnType("datetime");

                entity.Property(e => e.HoraSalida).HasColumnType("datetime");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkInventarioLibroNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.FkInventarioLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empresa_InventarionLibro");

                entity.HasOne(d => d.FkUsuarioNavigation)
                    .WithMany(p => p.Empresas)
                    .HasForeignKey(d => d.FkUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empresa_Usuraio");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("Genero");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventarionLibro>(entity =>
            {
                entity.ToTable("InventarionLibro");

                entity.Property(e => e.FechaEntradaLibro).HasColumnType("datetime");

                entity.Property(e => e.FechaSalidaLibro).HasColumnType("datetime");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.HasOne(d => d.FkLibroNavigation)
                    .WithMany(p => p.InventarionLibros)
                    .HasForeignKey(d => d.FkLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarionLibro_Libro");

                entity.HasOne(d => d.FkPrestamoNavigation)
                    .WithMany(p => p.InventarionLibros)
                    .HasForeignKey(d => d.FkPrestamo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarionLibro_Prestamo");

                entity.HasOne(d => d.FkReservaNavigation)
                    .WithMany(p => p.InventarionLibros)
                    .HasForeignKey(d => d.FkReserva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarionLibro_Reserva");

                entity.HasOne(d => d.FkVentaNavigation)
                    .WithMany(p => p.InventarionLibros)
                    .HasForeignKey(d => d.FkVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventarionLibro_Venta");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("Libro");

                entity.Property(e => e.AnioEdicion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Autor)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Editorial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Portada)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.FkGeneroNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.FkGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Libro_Genero");
            });

            modelBuilder.Entity<Multum>(entity =>
            {
                entity.Property(e => e.Sancion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TipoMulta)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Genero).HasMaxLength(1);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelCel).HasMaxLength(50);

                entity.HasOne(d => d.FkTipoDocumentoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.FkTipoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Persona_TipoDocumento");
            });

            modelBuilder.Entity<PersonaMultadum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkMultaNavigation)
                    .WithMany(p => p.PersonaMultada)
                    .HasForeignKey(d => d.FkMulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaMultada_Multa");

                entity.HasOne(d => d.FkUsuarioNavigation)
                    .WithMany(p => p.PersonaMultada)
                    .HasForeignKey(d => d.FkUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonaMultada_Usuraio");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.ToTable("Prestamo");

                entity.Property(e => e.EstadoLibro)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FechaDevolucion).HasColumnType("datetime");

                entity.Property(e => e.FehcaPrestamo).HasColumnType("datetime");

                entity.HasOne(d => d.FkLibroNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.FkLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestamo_Libro");

                entity.HasOne(d => d.FkUsuarioNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.FkUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prestamo_Usuraio");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("Reserva");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FehcaPrestamo).HasColumnType("datetime");

                entity.HasOne(d => d.FkLibroNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.FkLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserva_Libro");

                entity.HasOne(d => d.FkUsuarioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.FkUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reserva_Usuraio");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.ToTable("TipoDocumento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Siglas)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Usuraio>(entity =>
            {
                entity.ToTable("Usuraio");

                entity.HasOne(d => d.FkPresonaNavigation)
                    .WithMany(p => p.Usuraios)
                    .HasForeignKey(d => d.FkPresona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuraio_Persona");

                entity.HasOne(d => d.FkRolNavigation)
                    .WithMany(p => p.Usuraios)
                    .HasForeignKey(d => d.FkRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuraio_Rol");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.FormaDePago)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkLibroNavigation)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.FkLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Venta_Libro");

                entity.HasOne(d => d.FkLibro1)
                    .WithMany(p => p.Venta)
                    .HasForeignKey(d => d.FkLibro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Venta_Usuraio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
