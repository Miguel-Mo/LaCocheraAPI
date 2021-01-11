using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class VendedoresRepository : IVendedoresRepository
    {
        public CocherabbddContext _context { get; set; }

        public VendedoresRepository(CocherabbddContext context)
        {
            _context = context;
        }

        public ICollection<VendedorDTO> read()
        {
            throw new NotImplementedException();
        }

        public VendedorDTO read(int id)
        {
            throw new NotImplementedException();
        }
    }
}
