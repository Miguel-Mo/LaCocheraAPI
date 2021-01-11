using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class PropuestaVentaRepository : IPropuestaVentaRepository
    {
        public CocherabbddContext _context { get; set; }

        public PropuestaVentaRepository(CocherabbddContext context)
        {
            _context = context;
        }

        public ICollection<PropuestaVentaDTO> read()
        {
            throw new NotImplementedException();
        }

        public PropuestaVentaDTO read(int id)
        {
            throw new NotImplementedException();
        }
    }
}
