using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class UsuarioDTO : IEquatable<UsuarioDTO>
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
            return Equals(obj as UsuarioDTO);
        }

        public bool Equals(UsuarioDTO other)
        {
            return other != null &&
                   Id == other.Id &&
                   ConcesionarioId == other.ConcesionarioId &&
                   Login == other.Login &&
                   Tipo == other.Tipo &&
                   Nombre == other.Nombre &&
                   Apellidos == other.Apellidos &&
                   Dni == other.Dni &&
                   Email == other.Email &&
                   Telefono == other.Telefono &&
                   Salario == other.Salario;
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
