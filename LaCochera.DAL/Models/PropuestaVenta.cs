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
    }
}
