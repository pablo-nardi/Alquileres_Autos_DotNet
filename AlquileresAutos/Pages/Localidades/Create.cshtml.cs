using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Localidades
{
    public class CreateModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public CreateModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            try
            {
                ViewData["ProvinciaID"] = new SelectList(_context.Provincia, "ID", "Denominacion");
                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        [BindProperty]
        public Localidad Localidad { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                _context.Localidad.Add(Localidad);
                await _context.SaveChangesAsync();

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
