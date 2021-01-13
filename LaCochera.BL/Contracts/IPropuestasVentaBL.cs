﻿using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Contracts
{
    public interface IPropuestasVentaBL
    {
        ICollection<PropuestaVentaAmpliadoDTO> Read();
        PropuestaVentaAmpliadoDTO Read(int id);
    }
}
