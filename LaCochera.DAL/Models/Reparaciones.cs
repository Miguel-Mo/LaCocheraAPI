using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Reparaciones
    {
        public int Id { get; set; }
        public int MecanicoId { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoRepararId { get; set; }
        public string TiempoEstimado { get; set; }
        public string TiempoReal { get; set; }
        public int PresupuestoEstimado { get; set; }
        public int? PresupuestoReal { get; set; }
        public string Componentes { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Mecanicos Mecanico { get; set; }
        public virtual VehiculosReparar VehiculoReparar { get; set; }
    }
}
