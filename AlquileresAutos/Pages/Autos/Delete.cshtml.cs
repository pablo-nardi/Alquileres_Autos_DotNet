﻿using System;
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
            if (id == null || _context.Autos == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos.FirstOrDefaultAsync(m => m.ID == id);

            if (auto == null)
            {
                return NotFound();
            }
            else 
            {
                Auto = auto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Autos == null)
            {
                return NotFound();
            }
            var auto = await _context.Autos.FindAsync(id);

            if (auto != null)
            {
                Auto = auto;
                _context.Autos.Remove(Auto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
