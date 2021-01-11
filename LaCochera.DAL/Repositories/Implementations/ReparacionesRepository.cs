using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class ReparacionesRepository : IReparacionesRepository
    {
        public CocherabbddContext _context { get; set; }

        public ReparacionesRepository(CocherabbddContext context)
        {
            _context = context;
        }

        public ICollection<ReparacionDTO> Read()
        {
            throw new NotImplementedException();
        }

        public ReparacionDTO Read(int id)
        {
            throw new NotImplementedException();
        }
    }
}
