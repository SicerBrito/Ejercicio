using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Automovil{

        [Key]
        public int IdAutomovil { get; set; }
        public string ? Marca { get; set; }
        public string ? Modelo { get; set; }
        public int Año { get; set; }
        public string ? Tipo { get; set; }
        public int Capacidad { get; set; }
        public double PrecioDiario { get; set; }
        public ICollection<SucursalAutomovil>? SucursalDeAutomoviles { get; set; }
        public ICollection<Alquiler> ? Alquileres { get; set; }
        public ICollection<Reserva> ? Reservas { get; set; }

        
    }
