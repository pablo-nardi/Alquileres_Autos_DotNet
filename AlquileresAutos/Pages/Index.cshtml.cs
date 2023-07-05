using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlquileresAutos.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public string LocalidadSearch { get; set; }
        public IList<Auto> Autos { get; set; }
        public IndexModel(ILogger<IndexModel> logger, AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                LocalidadSearch = "ros";
                Autos = await _context.Autos
               .Include(a => a.Modelo)
               .Include(a => a.Sucursal)
               .Where(a => a.Sucursal.Localidad.Denominacion.ToUpper().Contains(LocalidadSearch.ToUpper()))
               .AsNoTracking().ToListAsync();

                return Page();
            }
            catch(Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }
    }
}