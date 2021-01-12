using LaCochera.BL.Contracts;
using LaCochera.Core.DTO;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.BL.Implementations
{
    public class VendedoresBL : IVendedoresBL
    {
        public IVendedoresRepository _vendedoresRepository { get; set; }

        public VendedoresBL(IVendedoresRepository vendedoresRepository)
        {
            _vendedoresRepository = vendedoresRepository;
        }

        public ICollection<VendedorDTO> Read()
        {
            return _vendedoresRepository.Read();
        }

        public VendedorDTO Read(int id)
        {
            return _vendedoresRepository.Read(id);
        }
    }
}
