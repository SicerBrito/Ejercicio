using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class RegistroEntrega{
        [Key]
        public int IdRegistro { get; set; }
        public int AlquilerId { get; set; }
        public Alquiler ? Alquileres { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado ? Empleados { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double CombustibleEntregado { get; set; }
        public int KilometrajeEntregado { get; set; }

    }
