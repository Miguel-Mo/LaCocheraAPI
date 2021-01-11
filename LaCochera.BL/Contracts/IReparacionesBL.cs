using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Contracts
{
    public interface IReparacionesBL
    {
        ICollection<ReparacionDTO> Read();
        ReparacionDTO Read(int id);
    }
}
