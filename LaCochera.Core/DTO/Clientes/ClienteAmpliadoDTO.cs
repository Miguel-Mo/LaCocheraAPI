using LaCochera.Core.DTO.Clientes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class ClienteAmpliadoDTO : ClienteDTO
    {
        public ClienteAmpliadoDTO()
        {
            PropuestaVenta = new HashSet<PropuestaVentaAmpliadoDTO>();
            Reparaciones = new HashSet<ReparacionAmpliadoDTO>();
        }

        public virtual ICollection<PropuestaVentaAmpliadoDTO> PropuestaVenta { get; set; }
        public virtual ICollection<ReparacionAmpliadoDTO> Reparaciones { get; set; }
    }
}
