using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class RegistroDevolucion{
        
        [Key]
        public int IdRegistro { get; set; }
        public int AlquilerId { get; set; }
        public Alquiler ? Alquileres { get; set; }
        public int EmpleadoId { get; set; }
        public Empleado ? Empleados { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public double CombustibleDevuelto { get; set; }
        public int KilometrajeDevuelto { get; set; }
        public double MontoAdicional { get; set; }
        
    }
