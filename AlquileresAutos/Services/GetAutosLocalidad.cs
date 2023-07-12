using AlquileresAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace AlquileresAutos.Services
{
    public class GetAutosLocalidad
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public IList<Auto> Autos { get; set; }

        public GetAutosLocalidad(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context= context;
        }
        public async Task<IList<Auto>> GetAutos(string LocalidadSearch)
        {
            Autos = await _context.Autos
            .Include(a => a.Modelo)
            .Include(a => a.Sucursal)
            .Where(a => a.Sucursal.Localidad.Denominacion.ToUpper().Contains(LocalidadSearch.ToUpper()))
            .AsNoTracking().ToListAsync();

            return Autos;
            
        }
    }
}
