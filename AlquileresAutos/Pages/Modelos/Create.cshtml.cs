using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Modelos
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
        ViewData["TipoAutoID"] = new SelectList(_context.TipoAutos, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Modelo Modelo { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Modelos.Add(Modelo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
