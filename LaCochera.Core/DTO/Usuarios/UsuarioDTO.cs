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

        public override bool Equals(object obj)
        {
            return obj is UsuarioDTO dTO &&
                   Id == dTO.Id &&
                   ConcesionarioId == dTO.ConcesionarioId &&
                   Login == dTO.Login &&
                   Tipo == dTO.Tipo &&
                   Nombre == dTO.Nombre &&
                   Apellidos == dTO.Apellidos &&
                   Dni == dTO.Dni &&
                   Email == dTO.Email &&
                   Telefono == dTO.Telefono &&
                   Salario == dTO.Salario;
        }

        public static bool operator ==(UsuarioDTO left, UsuarioDTO right)
        {
            return EqualityComparer<UsuarioDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(UsuarioDTO left, UsuarioDTO right)
        {
            return !(left == right);
        }
    }
}
