using LaCochera.Core.DTO.Vehiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO
{
    public class ConcesionarioDTO
    {
        public int Id { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ConcesionarioDTO dTO &&
                   Id == dTO.Id &&
                   Ciudad == dTO.Ciudad &&
                   Provincia == dTO.Provincia &&
                   Direccion == dTO.Direccion &&
                   Cp == dTO.Cp;
        }

        public static bool operator ==(ConcesionarioDTO left, ConcesionarioDTO right)
        {
            return EqualityComparer<ConcesionarioDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(ConcesionarioDTO left, ConcesionarioDTO right)
        {
            return !(left == right);
        }
    }
}
