using System;
using System.Collections.Generic;

namespace LaCochera.DAL.Models
{
    public partial class PropuestaVenta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VendedorId { get; set; }
        public int VehiculoVenderId { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime FechaLimite { get; set; }
        public int Presupuesto { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual VehiculosVender VehiculoVender { get; set; }
        public virtual Vendedores Vendedor { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PropuestaVenta venta &&
                   Id == venta.Id &&
                   ClienteId == venta.ClienteId &&
                   VendedorId == venta.VendedorId &&
                   VehiculoVenderId == venta.VehiculoVenderId &&
                   Estado == venta.Estado &&
                   FechaInicio == venta.FechaInicio &&
                   FechaFin == venta.FechaFin &&
                   FechaLimite == venta.FechaLimite &&
                   Presupuesto == venta.Presupuesto &&
                   EqualityComparer<Cliente>.Default.Equals(Cliente, venta.Cliente) &&
                   EqualityComparer<VehiculosVender>.Default.Equals(VehiculoVender, venta.VehiculoVender) &&
                   EqualityComparer<Vendedores>.Default.Equals(Vendedor, venta.Vendedor);
        }
    }
}
