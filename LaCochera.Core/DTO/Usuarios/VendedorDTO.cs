using LaCochera.Core.DTO.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class VendedorDTO
    {
        public int Id { get; set; }
        public int NumVentas { get; set; }
        public UsuarioNombreDTO Usuario { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VendedorDTO dTO &&
                   Id == dTO.Id &&
                   NumVentas == dTO.NumVentas &&
                   EqualityComparer<UsuarioNombreDTO>.Default.Equals(Usuario, dTO.Usuario);
        }
    }
}
