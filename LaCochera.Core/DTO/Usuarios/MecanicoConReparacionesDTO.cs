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

        public override bool Equals(object obj)
        {
            return obj is MecanicoConReparacionesDTO dTO &&
                   Id == dTO.Id &&
                   EsJefe == dTO.EsJefe &&
                   EqualityComparer<UsuarioDTO>.Default.Equals(Usuario, dTO.Usuario) &&
                   EqualityComparer<ICollection<EspecialidadDTO>>.Default.Equals(Especialidades, dTO.Especialidades) &&
                   EqualityComparer<ICollection<ReparacionAmpliadoDTO>>.Default.Equals(Reparaciones, dTO.Reparaciones);
        }
    }
}
