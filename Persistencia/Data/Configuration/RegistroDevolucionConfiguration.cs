using System.util.zlib;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;
public class RegistroDevolucionConfiguration : IEntityTypeConfiguration<RegistroDevolucion>
{
    public void Configure(EntityTypeBuilder<RegistroDevolucion> builder)
    {
        builder.ToTable("RegistroDevolucion");

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
            .WithMany(p => p.RegistroDeDevoluciones)
            .HasForeignKey(p => p.AlquilerId);

        builder.Property(p => p.EmpleadoId)
            .HasColumnName("EmpleadoId")
            .HasColumnType("int")
            .IsRequired();

        builder.HasOne(p => p.Empleados)
            .WithMany(p => p.RegistroDeDevoluciones)
            .HasForeignKey(p => p.EmpleadoId);

        builder.Property(p => p.FechaDevolucion)
            .HasColumnName("FechaDevolucion")
            .HasColumnType("date")
            .IsRequired();

        builder.Property(p => p.CombustibleDevuelto)
            .HasColumnName("CombustibleDevuelto")
            .HasColumnType("double")
            .IsRequired();

        builder.Property(p => p.KilometrajeDevuelto)
            .HasColumnName("KilometrajeDevuelto")
            .HasColumnType("int")
            .IsRequired();

        builder.Property(p => p.MontoAdicional)
            .HasColumnName("MontoAdicional")
            .HasColumnType("double")
            .IsRequired();
    }
}
