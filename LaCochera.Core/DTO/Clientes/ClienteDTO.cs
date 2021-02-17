using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Clientes
{
    public class ClienteDTO : IEquatable<ClienteDTO>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int Presupuesto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionVehiculo { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as ClienteDTO);
        }

        public bool Equals(ClienteDTO other)
        {
            return other != null &&
                   Id == other.Id &&
                   Nombre == other.Nombre &&
                   Apellidos == other.Apellidos &&
                   Telefono == other.Telefono &&
                   Dni == other.Dni &&
                   Email == other.Email &&
                   Presupuesto == other.Presupuesto &&
                   FechaRegistro == other.FechaRegistro &&
                   DescripcionVehiculo == other.DescripcionVehiculo;
        }

        public static bool operator ==(ClienteDTO left, ClienteDTO right)
        {
            return EqualityComparer<ClienteDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(ClienteDTO left, ClienteDTO right)
        {
            return !(left == right);
        }
    }
}
