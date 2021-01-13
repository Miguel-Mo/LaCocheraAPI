using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class VendedorConVentasDTO : VendedorDTO
    {
        public VendedorConVentasDTO()
        {
            PropuestaVenta = new HashSet<PropuestaVentaAmpliadoDTO>();
        }

        public ICollection<PropuestaVentaAmpliadoDTO> PropuestaVenta { get; set; }
    }
}
