using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            PropuestaVenta = new HashSet<PropuestaVenta>();
            Reparaciones = new HashSet<Reparaciones>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int Presupuesto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionVehiculo { get; set; }

        public virtual ICollection<PropuestaVenta> PropuestaVenta { get; set; }
        public virtual ICollection<Reparaciones> Reparaciones { get; set; }
    }
}
