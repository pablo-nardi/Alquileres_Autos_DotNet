using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Sucursales
{
    public class DetailsModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DetailsModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

      public Sucursal Sucursal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sucursal == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursal.FirstOrDefaultAsync(m => m.ID == id);
            if (sucursal == null)
            {
                return NotFound();
            }
            else 
            {
                Sucursal = sucursal;
            }
            return Page();
        }
    }
}
