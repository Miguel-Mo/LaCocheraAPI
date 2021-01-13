using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Contracts
{
    public interface IReparacionesBL
    {
        ICollection<ReparacionAmpliadoDTO> Read();
        ReparacionAmpliadoDTO Read(int id);
    }
}
