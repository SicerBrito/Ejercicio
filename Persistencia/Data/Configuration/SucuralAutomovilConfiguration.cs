using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class SucuralAutomovilConfiguration : IEntityTypeConfiguration<SucursalAutomovil>
{
    public void Configure(EntityTypeBuilder<SucursalAutomovil> builder)
    {

        builder.ToTable("SucuralAutomovil");

        builder.Property(p => p.IdSucursalAutomovil)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdSucursalAutomovil")
            .HasColumnType("int")
            .IsRequired();


        builder.Property(p => p.IdSucursal)
            .HasColumnName("IdSucursal")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Sucursales)
            .WithMany(p => p.SucursalDeAutomoviles)
            .HasForeignKey(p => p.IdSucursal);

        builder.Property(p => p.IdAutomovil)
            .HasColumnName("IdAutomovil")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Automoviles)
            .WithMany(p => p.SucursalDeAutomoviles)
            .HasForeignKey(p => p.IdAutomovil);

        builder.Property(p => p.CantidadDisponible)
            .HasColumnName("CantidadDisponible")
            .HasColumnType("int")
            .IsRequired();
    }
}
