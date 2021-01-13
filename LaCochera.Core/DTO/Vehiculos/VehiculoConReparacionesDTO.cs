using LaCochera.Core.DTO.Reparaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class VehiculoConReparacionesDTO : VehiculoRepararDTO
    {
        public VehiculoConReparacionesDTO()
        {
            Reparaciones = new HashSet<ReparacionDTO>();
        }

        public ICollection<ReparacionDTO> Reparaciones { get; set; }
    }
}
