using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Ventas
{
    public class PropuestaVentaDTO
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaLimite { get; set; }
        public int Presupuesto { get; set; }
    }
}
