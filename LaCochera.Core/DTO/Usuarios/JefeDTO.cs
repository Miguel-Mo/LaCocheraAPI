using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class JefeDTO
    {
        public int Id { get; set; }

        public UsuarioDTO Usuario { get; set; }

        public override bool Equals(object obj)
        {
            return obj is JefeDTO dTO &&
                   Id == dTO.Id &&
                   EqualityComparer<UsuarioDTO>.Default.Equals(Usuario, dTO.Usuario);
        }
    }
}
