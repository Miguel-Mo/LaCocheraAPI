using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class TiposVehiculos
    {
        public TiposVehiculos()
        {
            Especialidades = new HashSet<Especialidades>();
            Vehiculos = new HashSet<Vehiculos>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Especialidades> Especialidades { get; set; }
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
