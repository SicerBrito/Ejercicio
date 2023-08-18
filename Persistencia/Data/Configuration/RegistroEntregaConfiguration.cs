using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class RegistroEntregaConfiguration : IEntityTypeConfiguration<RegistroEntrega>
{
    public void Configure(EntityTypeBuilder<RegistroEntrega> builder)
    {
        builder.ToTable("RegistroEntrega");

        builder.Property(p => p.IdRegistro)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("IdRegistro")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.AlquilerId)
            .HasColumnName("AlquilerId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Alquileres)
            .WithMany(p => p.RegistroDeEntregas)
            .HasForeignKey(p => p.AlquilerId);

        builder.Property(p => p.EmpleadoId)
            .HasColumnName("EmpleadoId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Empleados)
            .WithMany(p => p.RegistroDeEntregas)
            .HasForeignKey(p => p.EmpleadoId);

        builder.Property(p => p.FechaEntrega)
            .HasColumnName("FechaEntrega")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.CombustibleEntregado)
           .HasColumnName("CombustibleEntregado")
           .HasColumnType("double")
           .IsRequired();

        builder.Property(p => p.KilometrajeEntregado)
           .HasColumnName("KilometrajeEntregado")
           .HasColumnType("int")
           .IsRequired();

           
    }
}
