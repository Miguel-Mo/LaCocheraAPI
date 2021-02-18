using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class VehiculoDTO
    {
        public int Id { get; set; }

        public string Potencia { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public ConcesionarioDTO Concesionario { get; set; }
        public TipoVehiculoDTO Tipo { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VehiculoDTO dTO &&
                   Id == dTO.Id &&
                   Potencia == dTO.Potencia &&
                   Marca == dTO.Marca &&
                   Modelo == dTO.Modelo &&
                   FechaRegistro == dTO.FechaRegistro &&
                   EqualityComparer<ConcesionarioDTO>.Default.Equals(Concesionario, dTO.Concesionario) &&
                   EqualityComparer<TipoVehiculoDTO>.Default.Equals(Tipo, dTO.Tipo);
        }

        public static bool operator ==(VehiculoDTO left, VehiculoDTO right)
        {
            return EqualityComparer<VehiculoDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(VehiculoDTO left, VehiculoDTO right)
        {
            return !(left == right);
        }
    }
}
