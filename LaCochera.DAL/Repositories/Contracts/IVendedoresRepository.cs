using LaCochera.Core.DTO;
//using LaCochera.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Contracts
{
    public interface IVendedoresRepository
    {
        ICollection<VendedorDTO> Read();
        VendedorDTO Read(int id);
    }
}
