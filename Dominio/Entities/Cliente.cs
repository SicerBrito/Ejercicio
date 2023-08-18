using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Cliente{
        
        [Key]
        public int IdCliente { get; set; }
        public string ? Nombres { get; set; }
        public string ? Apellidos { get; set; }
        public string ? DNI { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }
        public string ? Email { get; set; }
        public ICollection<Alquiler> ? Alquileres { get; set; }
        public ICollection<Reserva> ? Reservas { get; set; }


        
    }
