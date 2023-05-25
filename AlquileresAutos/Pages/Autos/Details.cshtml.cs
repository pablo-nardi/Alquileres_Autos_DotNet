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
    public class DetailsModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DetailsModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

      public Auto Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
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
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }
    }
}
