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
    public class DetailsModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DetailsModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

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
    }
}
