using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Reserva{
        [Key]
        public int IdReserva { get; set; }
        public int ClienteId { get; set; }
        public Cliente ? Clientes { get; set; }
        public int AutomovilId { get; set; }
        public Automovil ? Automoviles { get; set; }
        public DateTime FechaReserva { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFin { get; set; }
        public string ? Estado { get; set; }
        
        
    }
