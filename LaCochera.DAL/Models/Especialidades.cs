using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Especialidades
    {
        public int TipoId { get; set; }
        public int MecanicoId { get; set; }

        public virtual Mecanicos Mecanico { get; set; }
        public virtual TiposVehiculos Tipo { get; set; }
    }
}
