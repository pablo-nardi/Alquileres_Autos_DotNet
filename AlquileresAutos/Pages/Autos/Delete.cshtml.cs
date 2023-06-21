using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Autos
{
    public class DeleteModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DeleteModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Auto Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Autos == null)
                {
                    return NotFound();
                }

                Auto = await _context.Autos
                    .Include(s => s.Sucursal)
                    .Include(m => m.Modelo)
                    .FirstOrDefaultAsync(a => a.ID == id);

                if (Auto == null)
                {
                    return NotFound();
                }

                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            try
            {
                if (id == null || _context.Autos == null)
                {
                    return NotFound();
                }

                Auto = await _context.Autos.FindAsync(id);

                if (Auto != null)
                {
                    _context.Autos.Remove(Auto);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }
    }
}
