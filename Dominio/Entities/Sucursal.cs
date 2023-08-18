using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class Sucursal{
        [Key]
        public int IdSucursal { get; set; }
        public string ? Nombre { get; set; }
        public string ? Direccion { get; set; }
        public string ? Telefono { get; set; }
        public ICollection<SucursalAutomovil> ? SucursalDeAutomoviles { get; set; }
        
    }
