using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class PropuestaVentaRepository : IPropuestaVentaRepository
    {
        public CocherabbddContext _context { get; set; }
        private IMapper _mapper;

        public PropuestaVentaRepository(CocherabbddContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<PropuestaVentaDTO> Read()
        {
            var lista = _context.PropuestaVenta.ToList();

            var listaDTO = _mapper.Map<ICollection<PropuestaVentaDTO>>(lista);

            return listaDTO;
        }

        public PropuestaVentaDTO Read(int id)
        {
            var item = _context.PropuestaVenta.Find(id);

            return _mapper.Map<PropuestaVentaDTO>(item);
        }
    }
}
