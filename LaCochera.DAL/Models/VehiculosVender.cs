using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class VehiculosVender
    {
        public VehiculosVender()
        {
            PropuestaVenta = new HashSet<PropuestaVenta>();
        }

        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public decimal Precio { get; set; }
        public bool Vendido { get; set; }
        public bool SegundaMano { get; set; }
        public string TiempoUsado { get; set; }
        public string Imagen { get; set; }
        public int? KmRecorridos { get; set; }
        public int? CombustibleId { get; set; }

        public virtual CombustibleVehiculos Combustible { get; set; }
        public virtual Vehiculos Vehiculo { get; set; }
        public virtual ICollection<PropuestaVenta> PropuestaVenta { get; set; }
    }
}
