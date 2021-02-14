using AutoMapper;
using LaCochera.Core.DTO;
using LaCochera.Core.DTO.Ventas;
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

        public ICollection<PropuestaVentaAmpliadoDTO> Read()
        {
            var lista = _context.PropuestaVenta
                .Include(venta => venta.VehiculoVender)
                    .ThenInclude(vehiculo =>vehiculo.Vehiculo)
                .Include(venta => venta.Cliente)
                .Include(venta => venta.Vendedor)
                    .ThenInclude(vendedor => vendedor.Usuario)
                .OrderBy(venta => venta.FechaInicio)
                .ToList();

            var listaDTO = _mapper.Map<ICollection<PropuestaVentaAmpliadoDTO>>(lista);

            return listaDTO;
        }

        public PropuestaVentaAmpliadoDTO Read(int id)
        {
            var item = _context.PropuestaVenta
                .Include(venta => venta.VehiculoVender)
                    .ThenInclude(vehiculoVender => vehiculoVender.Vehiculo)
                        .ThenInclude(vehiculo => vehiculo.Concesionario)
                .Include(venta => venta.VehiculoVender)
                    .ThenInclude(vehiculoVender => vehiculoVender.Vehiculo)
                        .ThenInclude(vehiculo => vehiculo.Tipo)    // es raro, pero se hace así
                .Include(venta => venta.Cliente)
                .Include(venta => venta.Vendedor)
                    .ThenInclude(vendedor => vendedor.Usuario)
                .Where(venta => venta.Id == id)
                .ToList()[0];

            return _mapper.Map<PropuestaVentaAmpliadoDTO>(item);
        }
    }
}
