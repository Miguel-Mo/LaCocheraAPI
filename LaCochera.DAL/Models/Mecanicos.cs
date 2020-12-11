using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Mecanicos
    {
        public Mecanicos()
        {
            Especialidades = new HashSet<Especialidades>();
            Reparaciones = new HashSet<Reparaciones>();
        }

        public int Id { get; set; }
        public bool EsJefe { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Usuarios Usuario { get; set; }
        public virtual ICollection<Especialidades> Especialidades { get; set; }
        public virtual ICollection<Reparaciones> Reparaciones { get; set; }
    }
}
