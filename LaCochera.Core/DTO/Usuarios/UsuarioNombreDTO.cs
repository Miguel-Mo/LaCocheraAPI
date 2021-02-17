using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class UsuarioNombreDTO
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public override bool Equals(object obj)
        {
            return obj is UsuarioNombreDTO dTO &&
                   Nombre == dTO.Nombre &&
                   Apellidos == dTO.Apellidos;
        }
    }
}
