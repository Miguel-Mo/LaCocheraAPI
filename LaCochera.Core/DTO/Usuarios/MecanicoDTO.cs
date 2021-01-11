using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class MecanicoDTO
    {
        public MecanicoDTO()
        {
            Reparaciones = new HashSet<ReparacionDTO>();
        }

        public int Id { get; set; }
        public bool EsJefe { get; set; }

        public UsuarioDTO Usuario { get; set; }
        public ICollection<ReparacionDTO> Reparaciones { get; set; }
    }
}
