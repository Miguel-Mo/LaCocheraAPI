using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Usuarios;
using LaCochera.DAL.Models;
using LaCochera.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaCochera.DAL.Repositories.Implementations
{
    public class VendedoresRepository : IVendedoresRepository
    {
        public CocherabbddContext _context { get; set; }
        private IMapper _mapper;

        public VendedoresRepository(CocherabbddContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ICollection<VendedorNombreDTO> Read()
        {
            var lista = _context.Vendedores.ToList();

            var listaDTO = _mapper.Map<ICollection<VendedorNombreDTO>>(lista);

            return listaDTO;
        }

        public VendedorDTO Read(int id)
        {
            var item = _context.Vendedores.Find(id);

            return _mapper.Map<VendedorDTO>(item);
        }

        ICollection<VendedorDTO> IVendedoresRepository.Read()
        {
            throw new NotImplementedException();
        }
    }
}
