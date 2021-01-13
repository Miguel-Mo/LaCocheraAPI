using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Reparaciones
{
    public class ReparacionDTO
    {
        public int Id { get; set; }
        public string TiempoEstimado { get; set; }
        public string TiempoReal { get; set; }
        public int PresupuestoEstimado { get; set; }
        public int PresupuestoReal { get; set; }
        public string Componentes { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
