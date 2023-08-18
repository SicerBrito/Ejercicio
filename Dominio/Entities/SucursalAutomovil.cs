using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;
    public class SucursalAutomovil{
        
        [Key]
        public int IdSucursalAutomovil { get; set; }
        public int IdSucursal { get; set; }
        public Sucursal ? Sucursales { get; set; }
        public int IdAutomovil { get; set; }
        public Automovil ? Automoviles { get; set; }
        public int CantidadDisponible { get; set; }

    }
