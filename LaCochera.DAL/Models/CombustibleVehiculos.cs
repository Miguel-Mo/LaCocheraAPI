using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class CombustibleVehiculos
    {
        public CombustibleVehiculos()
        {
            VehiculosVender = new HashSet<VehiculosVender>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<VehiculosVender> VehiculosVender { get; set; }
    }
}
