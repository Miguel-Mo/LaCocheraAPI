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

        public override bool Equals(object obj)
        {
            return obj is MecanicoDTO dTO &&
                   Id == dTO.Id &&
                   EsJefe == dTO.EsJefe &&
                   EqualityComparer<UsuarioDTO>.Default.Equals(Usuario, dTO.Usuario) &&
                   EqualityComparer<ICollection<EspecialidadDTO>>.Default.Equals(Especialidades, dTO.Especialidades);
        }
    }
}
