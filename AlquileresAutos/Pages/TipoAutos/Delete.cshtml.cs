using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.TipoAutos
{
    public class DeleteModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DeleteModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TipoAuto TipoAuto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipoAutos == null)
            {
                return NotFound();
            }

            var tipoauto = await _context.TipoAutos.FirstOrDefaultAsync(m => m.ID == id);

            if (tipoauto == null)
            {
                return NotFound();
            }
            else 
            {
                TipoAuto = tipoauto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TipoAutos == null)
            {
                return NotFound();
            }
            var tipoauto = await _context.TipoAutos.FindAsync(id);

            if (tipoauto != null)
            {
                TipoAuto = tipoauto;
                _context.TipoAutos.Remove(TipoAuto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
