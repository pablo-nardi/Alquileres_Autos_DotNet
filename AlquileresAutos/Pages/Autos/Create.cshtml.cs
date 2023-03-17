using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Autos
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
            return Page();
        }

        [BindProperty]
        public Auto Auto { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Autos.Add(Auto);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
