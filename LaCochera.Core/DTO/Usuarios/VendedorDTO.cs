using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class VendedorDTO
    {
        public VendedorDTO()
        {
            PropuestaVenta = new HashSet<PropuestaVentaDTO>();
        }

        public int Id { get; set; }
        public int NumVentas { get; set; }
        public int UsuarioId { get; set; }

        public UsuarioDTO Usuario { get; set; }
        public ICollection<PropuestaVentaDTO> PropuestaVenta { get; set; }
    }
}
