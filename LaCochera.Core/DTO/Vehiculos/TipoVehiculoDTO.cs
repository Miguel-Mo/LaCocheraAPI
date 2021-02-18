using LaCochera.Core.DTO.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class TipoVehiculoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TipoVehiculoDTO dTO &&
                   Id == dTO.Id &&
                   Descripcion == dTO.Descripcion;
        }

        public static bool operator ==(TipoVehiculoDTO left, TipoVehiculoDTO right)
        {
            return EqualityComparer<TipoVehiculoDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(TipoVehiculoDTO left, TipoVehiculoDTO right)
        {
            return !(left == right);
        }
    }
}
