using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Cliente");

        builder.Property(p => p.IdCliente)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdCliente")
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

        builder.Property(p => p.Email)
           .HasColumnName("Email")
           .HasColumnType("varchar")
           .HasMaxLength(100)
           .IsRequired();


    }
}
