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

        public override bool Equals(object obj)
        {
            return obj is PropuestaVentaDTO dTO &&
                   Id == dTO.Id &&
                   Estado == dTO.Estado &&
                   FechaInicio == dTO.FechaInicio &&
                   FechaFin == dTO.FechaFin &&
                   FechaLimite == dTO.FechaLimite &&
                   Presupuesto == dTO.Presupuesto;
        }
    }
}
