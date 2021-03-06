﻿using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Ventas;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Contracts
{
    public interface IPropuestaVentaRepository
    {
        ICollection<PropuestaVentaAmpliadoDTO> Read();
        PropuestaVentaAmpliadoDTO Read(int id);
    }
}
