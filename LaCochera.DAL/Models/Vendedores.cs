using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Vendedores
    {
        public Vendedores()
        {
            PropuestaVenta = new HashSet<PropuestaVenta>();
        }

        public int Id { get; set; }
        public int NumVentas { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Usuarios Usuario { get; set; }
        public virtual ICollection<PropuestaVenta> PropuestaVenta { get; set; }
    }
}
