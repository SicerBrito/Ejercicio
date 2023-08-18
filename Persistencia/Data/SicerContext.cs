using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
public class SicerContext : DbContext
{
    public SicerContext(DbContextOptions<SicerContext> options) : base (options){

    }

    public DbSet<Alquiler> ? Alquileres { get; set; } = null!;
    public DbSet<Automovil> ? Automoviles { get; set; } = null!;
    public DbSet<Cliente> ? Clientes { get; set; } = null!;
    public DbSet<Empleado> ? Empleados { get; set; } = null!;
    public DbSet<RegistroDevolucion> ? RegistroDeDevoluciones { get; set; } = null!;
    public DbSet<RegistroEntrega> ? RegistroDeEntregas { get; set; } = null!;
    public DbSet<Reserva> ? Reservas { get; set; } = null!;
    public DbSet<Sucursal> ? Sucursales { get; set; } = null!;
    public DbSet<SucursalAutomovil> ? SucursalDeAutomoviles { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}
