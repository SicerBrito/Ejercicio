using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Alquiler{

        [Key]
        public int IdAlquiler { get; set; }
        public int ClienteId { get; set; }
        public Cliente ? Clientes { get; set; }
        public int AutomovilId { get; set; }
        public Automovil ? Automoviles { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFin { get; set; }
        public double CostoTotal { get; set; }
        public string ? Estado { get; set; }
        public ICollection<RegistroDevolucion> ? RegistroDeDevoluciones { get; set; }
        public ICollection<RegistroEntrega> ? RegistroDeEntregas { get; set; }


    }
