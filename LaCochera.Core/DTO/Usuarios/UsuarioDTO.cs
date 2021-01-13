using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public int ConcesionarioId { get; set; }
        public string Login { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }
    }
}
