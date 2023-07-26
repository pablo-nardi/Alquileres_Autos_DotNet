using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlquileresAutos.Models;
using AlquileresAutos.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContosoUniversity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        [BindProperty]
        public int ProvinciaID { get; set; }
        public int LocalidadID { get; set; }
        public Provincia Provincia { get; set; }
        public IList<Auto> Autos { get; set; }
        public GetAutosLocalidad _GetAutosLocalidad { get; set; }
        public IList<Provincia> Provincias { get; set; }
        public IEnumerable<Localidad> Localidades { get; set; }
        public IndexModel(  ILogger<IndexModel> logger, 
                            AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _logger = logger;
            _context = context;
            _GetAutosLocalidad = new GetAutosLocalidad(_context);
        }
        public async Task<IActionResult> OnGetAsync(int? ProvinciaID, int? LocalidadID)
        {
            Provincias = await _context.Provincia
                .Include(p => p.Localidades)
                .ToListAsync();
            if (ProvinciaID != null)
            {
                Provincia = Provincias.Where(i => i.ID == ProvinciaID.Value).FirstOrDefault();
                Localidades = Provincia.Localidades;
            }
            if (LocalidadID != null)
            {
                Autos = await _GetAutosLocalidad.GetAutos(LocalidadID.Value);
            }

            return Page();
        }
       
    }
}