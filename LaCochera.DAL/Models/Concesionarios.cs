using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Concesionarios
    {
        public Concesionarios()
        {
            Usuarios = new HashSet<Usuarios>();
            Vehiculos = new HashSet<Vehiculos>();
        }

        public int Id { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Cp { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
