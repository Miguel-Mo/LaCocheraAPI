using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class VehiculoVenderDTO
    {
        public int Id { get; set; }
        public decimal Precio { get; set; }
        public bool Vendido { get; set; }
        public bool SegundaMano { get; set; }
        public string TiempoUsado { get; set; }
        public string Imagen { get; set; }
        public int KmRecorridos { get; set; }

        public CombustibleDTO Combustible { get; set; }
        public VehiculoDTO Vehiculo { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VehiculoVenderDTO dTO &&
                   Id == dTO.Id &&
                   Precio == dTO.Precio &&
                   Vendido == dTO.Vendido &&
                   SegundaMano == dTO.SegundaMano &&
                   TiempoUsado == dTO.TiempoUsado &&
                   Imagen == dTO.Imagen &&
                   KmRecorridos == dTO.KmRecorridos &&
                   EqualityComparer<CombustibleDTO>.Default.Equals(Combustible, dTO.Combustible) &&
                   EqualityComparer<VehiculoDTO>.Default.Equals(Vehiculo, dTO.Vehiculo);
        }

        public static bool operator ==(VehiculoVenderDTO left, VehiculoVenderDTO right)
        {
            return EqualityComparer<VehiculoVenderDTO>.Default.Equals(left, right);
        }

        public static bool operator !=(VehiculoVenderDTO left, VehiculoVenderDTO right)
        {
            return !(left == right);
        }
    }
}
