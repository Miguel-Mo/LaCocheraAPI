using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Jefe
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Usuarios Usuario { get; set; }
    }
}
