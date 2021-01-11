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
    }
}
