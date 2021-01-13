using LaCochera.Core.DTO.Clientes;
using LaCochera.Core.DTO.Reparaciones;
using LaCochera.Core.DTO.Vehiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class ReparacionAmpliadoDTO : ReparacionDTO
    {
        public ClienteDTO Cliente { get; set; }
        public MecanicoDTO Mecanico { get; set; }
        public VehiculoRepararDTO VehiculoReparar { get; set; }
    }
}
