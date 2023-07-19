using AlquileresAutos.Data;
using AlquileresAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlquileresAutos.Pages
{
    
    public class MedioDePagoModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public Auto Auto { get; set; }
        
        public MedioDePagoModel(AlquileresAutosContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(int? id)
        {
            if (id != null)
            {
                Auto = await _context.Autos.FindAsync(id);
            }
        }
    }
}
