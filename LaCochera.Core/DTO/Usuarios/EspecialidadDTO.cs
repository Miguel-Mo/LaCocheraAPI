using LaCochera.Core.DTO.Vehiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class EspecialidadDTO
    {
        public MecanicoDTO Mecanico { get; set; }
        public TipoVehiculoDTO Tipo { get; set; }
    }
}
