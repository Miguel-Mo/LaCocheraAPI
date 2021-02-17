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

        public override bool Equals(object obj)
        {
            return obj is Usuarios usuarios &&
                   Id == usuarios.Id &&
                   ConcesionarioId == usuarios.ConcesionarioId &&
                   Login == usuarios.Login &&
                   Password == usuarios.Password &&
                   Tipo == usuarios.Tipo &&
                   Nombre == usuarios.Nombre &&
                   Apellidos == usuarios.Apellidos &&
                   Dni == usuarios.Dni &&
                   Email == usuarios.Email &&
                   Telefono == usuarios.Telefono &&
                   Salario == usuarios.Salario &&
                   EqualityComparer<Concesionarios>.Default.Equals(Concesionario, usuarios.Concesionario) &&
                   EqualityComparer<ICollection<Jefe>>.Default.Equals(Jefe, usuarios.Jefe) &&
                   EqualityComparer<ICollection<Mecanicos>>.Default.Equals(Mecanicos, usuarios.Mecanicos) &&
                   EqualityComparer<ICollection<Vendedores>>.Default.Equals(Vendedores, usuarios.Vendedores);
        }
    }
}
