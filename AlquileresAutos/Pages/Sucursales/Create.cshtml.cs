using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Sucursales
{
    public class CreateModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public ICollection<string> horas { get; set; }

        public CreateModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["LocalidadID"] = new SelectList(_context.Localidad, "ID", "Denominacion");
            return Page();
        }

        [BindProperty]
        public Sucursal Sucursal { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sucursal.Add(Sucursal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
