using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleado");

        builder.Property(p => p.IdEmpleado)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdEmpleado")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.Nombres)
           .HasColumnName("Nombres")
           .HasColumnType("varchar")
           .HasMaxLength(100)
           .IsRequired();
        
        builder.Property(p => p.Apellidos)
           .HasColumnName("Apellidos")
           .HasColumnType("varchar")
           .HasMaxLength(100)
           .IsRequired();

        builder.Property(p => p.DNI)
           .HasColumnName("DNI")
           .HasColumnType("varchar")
           .HasMaxLength(20)
           .IsRequired();

        builder.Property(p => p.Direccion)
           .HasColumnName("Direccion")
           .HasColumnType("varchar")
           .HasMaxLength(255)
           .IsRequired();

        builder.Property(p => p.Telefono)
           .HasColumnName("Telefono")
           .HasColumnType("varchar")
           .HasMaxLength(20)
           .IsRequired();

        builder.Property(p => p.Cargo)
           .HasColumnName("Cargo")
           .HasColumnType("varchar")
           .HasMaxLength(50)
           .IsRequired();
    }
}
