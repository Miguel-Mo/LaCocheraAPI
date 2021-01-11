using LaCochera.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Contracts
{
    public interface IVendedoresBL
    {
        ICollection<VendedorDTO> Read();
        VendedorDTO Read(int id);
    }
}
