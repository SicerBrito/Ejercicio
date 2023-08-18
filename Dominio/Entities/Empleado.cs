using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Empleado{

        [Key]
        public int IdEmpleado { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? DNI { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }
        public string ? Cargo { get; set; }
        public ICollection<RegistroDevolucion> ? RegistroDeDevoluciones { get; set; }
        public ICollection<RegistroEntrega> ? RegistroDeEntregas { get; set; }

        
    }
