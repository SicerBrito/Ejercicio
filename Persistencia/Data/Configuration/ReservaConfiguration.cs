using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ReservaConfiguration : IEntityTypeConfiguration<Reserva>
{
    public void Configure(EntityTypeBuilder<Reserva> builder)
    {
        builder.ToTable("Reserva");

        builder.Property(p => p.IdReserva)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdReserva")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.ClienteId)
            .HasColumnName("ClienteId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Clientes)
            .WithMany(p => p.Reservas)
            .HasForeignKey(p => p.ClienteId);

        builder.Property(p => p.AutomovilId)
            .HasColumnName("AutomovilId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Automoviles)
            .WithMany(p => p.Reservas)
            .HasForeignKey(p => p.AutomovilId);

        builder.Property(p => p.FechaReserva)
            .HasColumnName("FechaReserva")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.FechaIncio)
            .HasColumnName("FechaIncio")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.FechaFin)
            .HasColumnName("FechaFin")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.Estado)
            .HasColumnName("Estado")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();
    }
}
