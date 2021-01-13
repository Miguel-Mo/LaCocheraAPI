using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class MecanicoConReparacionesDTO : MecanicoDTO
    {
        public MecanicoConReparacionesDTO() : base()
        {
            Reparaciones = new HashSet<ReparacionAmpliadoDTO>();
        }

        public ICollection<ReparacionAmpliadoDTO> Reparaciones { get; set; }
    }
}
