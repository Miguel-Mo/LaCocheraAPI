using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Vehiculos;
using LaCochera.Core.DTO.Ventas;
using System.Collections.Generic;

namespace LaCochera.Core.DTO
{
    public class PropuestaVentaAmpliadoDTO : PropuestaVentaDTO
    {
        public ClienteDTO Cliente { get; set; }
        public VehiculoVenderDTO VehiculoVender { get; set; }
        public VendedorDTO Vendedor { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PropuestaVentaAmpliadoDTO dTO &&
                   base.Equals(obj) &&
                   Id == dTO.Id &&
                   Estado == dTO.Estado &&
                   FechaInicio == dTO.FechaInicio &&
                   FechaFin == dTO.FechaFin &&
                   FechaLimite == dTO.FechaLimite &&
                   Presupuesto == dTO.Presupuesto &&
                   EqualityComparer<ClienteDTO>.Default.Equals(Cliente, dTO.Cliente) &&
                   EqualityComparer<VehiculoVenderDTO>.Default.Equals(VehiculoVender, dTO.VehiculoVender) &&
                   EqualityComparer<VendedorDTO>.Default.Equals(Vendedor, dTO.Vendedor);
        }

        public static bool operator ==(PropuestaVentaAmpliadoDTO left, PropuestaVentaAmpliadoDTO right)
        {
            return EqualityComparer<PropuestaVentaAmpliadoDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(PropuestaVentaAmpliadoDTO left, PropuestaVentaAmpliadoDTO right)
        {
            return !(left == right);
        }
    }
}
