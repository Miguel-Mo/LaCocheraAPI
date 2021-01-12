using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class ReparacionesRepository : IReparacionesRepository
    {
        public CocherabbddContext _context { get; set; }
        private IMapper _mapper;

        public ReparacionesRepository(CocherabbddContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<ReparacionDTO> Read()
        {
            var lista = _context.Reparaciones.ToList();

            var listaDTO = _mapper.Map<ICollection<ReparacionDTO>>(lista);

            return listaDTO;
        }

        public ReparacionDTO Read(int id)
        {
            var item = _context.Reparaciones.Find(id);

            return _mapper.Map<ReparacionDTO>(item);
        }
    }
}
