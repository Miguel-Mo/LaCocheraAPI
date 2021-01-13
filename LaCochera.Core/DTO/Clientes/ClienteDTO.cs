using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Clientes
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public int Presupuesto { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionVehiculo { get; set; }
    }
}
