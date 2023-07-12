using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AlquileresAutos.Models;
using AlquileresAutos.Services;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        [BindProperty]
        public string LocalidadSearch { get; set; }
        public IList<Auto> Autos { get; set; }
        public GetAutosLocalidad _GetAutosLocalidad { get; set; }
        public IndexModel(  ILogger<IndexModel> logger, 
                            AlquileresAutos.Data.AlquileresAutosContext context
                            
                           )
        {
            _logger = logger;
            _context = context;
            _GetAutosLocalidad = new GetAutosLocalidad(_context);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                Autos = await _GetAutosLocalidad.GetAutos(LocalidadSearch);
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