using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Usuarios
{
    public class VendedorNombreDTO
    {
        public UsuarioNombreDTO Usuario { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VendedorNombreDTO dTO &&
                   EqualityComparer<UsuarioNombreDTO>.Default.Equals(Usuario, dTO.Usuario);
        }
    }
}
