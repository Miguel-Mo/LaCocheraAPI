using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class VehiculosReparar
    {
        public VehiculosReparar()
        {
            Reparaciones = new HashSet<Reparaciones>();
        }

        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public string Descripcion { get; set; }
        public string Matricula { get; set; }

        public virtual Vehiculos Vehiculo { get; set; }
        public virtual ICollection<Reparaciones> Reparaciones { get; set; }
    }
}
