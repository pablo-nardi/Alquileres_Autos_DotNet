using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Provincias
{
    public class IndexModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public IndexModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IEnumerable<Provincia> Provincias { get;set; } = default!;
        public int ProvinciaID { get; set; }
        public IEnumerable<Localidad> Localidades { get; set; } = default!;

        public async Task OnGetAsync(int? id)
        {
            if (_context.Provincia != null)
            {
                Provincias = await _context.Provincia
                    .Include(i => i.Localidades)
                    .ToListAsync();
            }

            if (id != null)
            {
                
                Provincia Provincia = Provincias
                    .Where(i => i.ID == id.Value).Single();
                Localidades = Provincia.Localidades;
            }
        }
    }
}
