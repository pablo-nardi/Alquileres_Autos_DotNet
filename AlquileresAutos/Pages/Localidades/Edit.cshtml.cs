using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Localidades
{
    public class EditModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public EditModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Localidad Localidad { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Localidad == null)
                {
                    return NotFound();
                }

                var localidad = await _context.Localidad.FirstOrDefaultAsync(m => m.ID == id);
                if (localidad == null)
                {
                    return NotFound();
                }
                Localidad = localidad;
                ViewData["ProvinciaID"] = new SelectList(_context.Provincia, "ID", "Denominacion");
                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _context.Attach(Localidad).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocalidadExists(Localidad.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        private bool LocalidadExists(int id)
        {
          return _context.Localidad.Any(e => e.ID == id);
        }
    }
}
