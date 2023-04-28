using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Modelos
{
    public class DeleteModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DeleteModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Modelo Modelo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Modelos == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelos
                                .AsNoTracking()
                                .Include(t => t.tipoAuto)
                                .FirstOrDefaultAsync(m => m.ID == id);

            if (modelo == null)
            {
                return NotFound();
            }
            else 
            {
                Modelo = modelo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Modelos == null)
            {
                return NotFound();
            }
            var modelo = await _context.Modelos.FindAsync(id);

            if (modelo != null)
            {
                Modelo = modelo;
                _context.Modelos.Remove(Modelo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
