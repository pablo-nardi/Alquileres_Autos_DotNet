using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Localidades
{
    public class DetailsModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public DetailsModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public Localidad Localidad { get; set; }

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
                else
                {
                    Localidad = localidad;
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
