using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class VehiculoRepararDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Matricula { get; set; }

        public VehiculoDTO Vehiculo { get; set; }

    }
}
