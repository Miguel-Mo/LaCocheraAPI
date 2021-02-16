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
    }
}
