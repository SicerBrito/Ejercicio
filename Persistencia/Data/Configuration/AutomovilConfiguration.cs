using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class AutomovilConfiguration : IEntityTypeConfiguration<Automovil>
{
    public void Configure(EntityTypeBuilder<Automovil> builder)
    {
        builder.ToTable("Automovil");

        builder.Property(p => p.IdAutomovil)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdAutomovil")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Marca)
            .HasColumnName("Marca")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(p => p.Modelo)
           .HasColumnName("Modelo")
           .HasColumnType("varchar")
           .HasMaxLength(100)
           .IsRequired();

        builder.Property(p => p.Año)
            .HasColumnName("Año")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Tipo)
            .HasColumnName("Tipo")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(p => p.Capacidad)
            .HasColumnName("Capacidad")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.PrecioDiario)
            .HasColumnName("PrecioDiario")
            .HasColumnType("double")
            .IsRequired();

            
    }
}
