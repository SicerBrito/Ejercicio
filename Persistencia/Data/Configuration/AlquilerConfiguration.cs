using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class AlquilerConfiguration : IEntityTypeConfiguration<Alquiler>
{
    public void Configure(EntityTypeBuilder<Alquiler> builder)
    {
        builder.ToTable("Alquiler");

        builder.Property(p => p.IdAlquiler)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdAlquiler")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.ClienteId)
            .HasColumnName("ClienteId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Clientes)
            .WithMany(p => p.Alquileres)
            .HasForeignKey(p => p.ClienteId);

        builder.Property(p => p.AutomovilId)
           .HasColumnName("AutomovilId")
           .HasColumnType("int")
           .IsRequired();

        builder.HasOne(p => p.Automoviles)
          .WithMany(p => p.Alquileres)
          .HasForeignKey(p => p.AutomovilId);

        builder.Property(p => p.FechaIncio)
            .HasColumnName("FechaIncio")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.FechaFin)
            .HasColumnName("FechaFin")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.CostoTotal)
            .HasColumnName("CostoTotal")
            .HasColumnType("double")
            .IsRequired();

        builder.Property(p => p.Estado)
           .HasColumnName("Estado")
           .HasColumnType("varchar")
           .HasMaxLength(50)
           .IsRequired();
    }
}
