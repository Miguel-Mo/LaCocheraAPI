using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Jefe = new HashSet<Jefe>();
            Mecanicos = new HashSet<Mecanicos>();
            Vendedores = new HashSet<Vendedores>();
        }

        public int Id { get; set; }
        public int ConcesionarioId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }

        public virtual Concesionarios Concesionario { get; set; }
        public virtual ICollection<Jefe> Jefe { get; set; }
        public virtual ICollection<Mecanicos> Mecanicos { get; set; }
        public virtual ICollection<Vendedores> Vendedores { get; set; }
    }
}
