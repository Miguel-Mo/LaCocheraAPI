using LaCochera.Core.DTO.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class MecanicoDTO
    {
        public MecanicoDTO()
        {
            Especialidades = new HashSet<EspecialidadDTO>();
        }

        public int Id { get; set; }
        public bool EsJefe { get; set; }
        public UsuarioDTO Usuario { get; set; }
        public ICollection<EspecialidadDTO> Especialidades { get; set; }
    }
}
