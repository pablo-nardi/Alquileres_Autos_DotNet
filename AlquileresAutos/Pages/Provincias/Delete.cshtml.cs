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
    public class DeleteModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DeleteModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Provincia Provincia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Provincia == null)
                {
                    return NotFound();
                }

                var provincia = await _context.Provincia.FirstOrDefaultAsync(m => m.ID == id);

                if (provincia == null)
                {
                    return NotFound();
                }
                else
                {
                    Provincia = provincia;
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
                if (id == null || _context.Provincia == null)
                {
                    return NotFound();
                }
                var provincia = await _context.Provincia.FindAsync(id);

                if (provincia != null)
                {
                    Provincia = provincia;
                    _context.Provincia.Remove(Provincia);
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
