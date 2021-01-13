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
    }
}
