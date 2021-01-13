using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Vehiculos;
using LaCochera.Core.DTO.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class PropuestaVentaAmpliadoDTO : Ventas.PropuestaVentaDTO
    {
        public ClienteDTO Cliente { get; set; }
        public VehiculoVenderDTO VehiculoVender { get; set; }
        public VendedorDTO Vendedor { get; set; }
    }
}
