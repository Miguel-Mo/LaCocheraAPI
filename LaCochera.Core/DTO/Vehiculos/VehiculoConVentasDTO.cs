using LaCochera.Core.DTO.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class VehiculoConVentasDTO : VehiculoVenderDTO
    {
        public VehiculoConVentasDTO()
        {
            PropuestaVenta = new HashSet<PropuestaVentaDTO>();
        }

        public ICollection<PropuestaVentaDTO> PropuestaVenta { get; set; }
    }
}
