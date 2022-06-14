using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication44.Modelo
{
    public partial class Aplication_oneContext : DbContext
    {
        public Aplication_oneContext()
        {
        }

        public Aplication_oneContext(DbContextOptions<Aplication_oneContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TableDisciplina> TableDisciplinas { get; set; }
        public virtual DbSet<TableEvento> TableEventos { get; set; }
        public virtual DbSet<TableJugador> TableJugadors { get; set; }
        public virtual DbSet<TableRegister> TableRegisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PERSONAL-PC\\TEW_SQLEXPRESS;Database=Aplication_one; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableDisciplina>(entity =>
            {
                entity.ToTable("Table__Disciplina");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CategoriaDeportiva)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Categoria_Deportiva");

                entity.Property(e => e.DisciplinaDeportiva)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Disciplina_Deportiva");

                entity.Property(e => e.NombreEquipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Equipo");
            });

            modelBuilder.Entity<TableEvento>(entity =>
            {
                entity.ToTable("Table_Evento");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.CategoriaEvneto)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Categoria_Evneto");

                entity.Property(e => e.IdEvento)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NombreEvento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_Evento");

                entity.Property(e => e.TipoEvento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_evento");
            });

            modelBuilder.Entity<TableJugador>(entity =>
            {
                entity.ToTable("TABLE_JUGADOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ApellidoJugador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Apellido_Jugador");

                entity.Property(e => e.EdadJugador)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Edad_jugador");

                entity.Property(e => e.IdDisciplina)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NombreJugador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_jugador");

                entity.Property(e => e.SexoJugador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Sexo_jugador");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.TableJugador)
                    .HasForeignKey<TableJugador>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABLE_JUGADOR_Table_Evento");

                entity.HasOne(d => d.IdDisciplinaNavigation)
                    .WithMany(p => p.TableJugadors)
                    .HasForeignKey(d => d.IdDisciplina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABLE_JUGADOR_Table__Disciplina");
            });

            modelBuilder.Entity<TableRegister>(entity =>
            {
                entity.ToTable("Table_registers");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Edad).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_nacimiento");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sexo).HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
