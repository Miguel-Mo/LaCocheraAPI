using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Vehiculos
    {
        public Vehiculos()
        {
            VehiculosReparar = new HashSet<VehiculosReparar>();
            VehiculosVender = new HashSet<VehiculosVender>();
        }

        public int Id { get; set; }
        public int TipoId { get; set; }
        public int ConcesionarioId { get; set; }
        public string Potencia { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Concesionarios Concesionario { get; set; }
        public virtual TiposVehiculos Tipo { get; set; }
        public virtual ICollection<VehiculosReparar> VehiculosReparar { get; set; }
        public virtual ICollection<VehiculosVender> VehiculosVender { get; set; }
    }
}
