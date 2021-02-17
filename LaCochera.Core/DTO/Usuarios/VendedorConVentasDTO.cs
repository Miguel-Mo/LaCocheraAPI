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

        public override bool Equals(object obj)
        {
            return obj is VendedorConVentasDTO dTO &&
                   Id == dTO.Id &&
                   NumVentas == dTO.NumVentas &&
                   EqualityComparer<UsuarioNombreDTO>.Default.Equals(Usuario, dTO.Usuario) &&
                   EqualityComparer<ICollection<PropuestaVentaAmpliadoDTO>>.Default.Equals(PropuestaVenta, dTO.PropuestaVenta);
        }
    }
}
