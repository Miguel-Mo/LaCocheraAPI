﻿using LaCochera.Core.DTO.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.Core.DTO.Vehiculos
{
    public class TipoVehiculoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ICollection<EspecialidadDTO> Especialidades { get; set; }
        public ICollection<VehiculoDTO> Vehiculos { get; set; }
    }
}