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
    }
}
