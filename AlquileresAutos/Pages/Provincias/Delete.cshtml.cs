using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;
using AlquileresAutos.Services;

namespace AlquileresAutos.Pages.Provincias
{
    public class DeleteModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public ProvinciaService ProvinciaService { get; set; }

        public DeleteModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
            ProvinciaService = new ProvinciaService();
        }

        [BindProperty]
        public Provincia Provincia { get; set; }

        public int valor;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Provincia == null)
                {
                    return NotFound();
                }

                var provincia = await _context.Provincia
                    .Include(l => l.Localidades)
                    .FirstOrDefaultAsync(p => p.ID == id);

                if (provincia == null)
                {
                    return NotFound();
                }
                else
                {
                    Provincia = provincia;
                }
                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            try
            {
                if (id == null || _context.Provincia == null)
                {
                    return NotFound();
                }

                var provincia = await _context.Provincia
                                .Include(l => l.Localidades)
                                .FirstOrDefaultAsync(p => p.ID == id);

                if (provincia != null)
                {
                    if (ProvinciaService.HayLocalidadesAsociadas(provincia))
                    {
                        Provincia = provincia;
                        _context.Provincia.Remove(Provincia);
                        await _context.SaveChangesAsync();
                    }
                    else
                    {
                        TempData["ErrorMessage"] = $"No se puede Eliminar la Provincia {provincia.Denominacion}  porque tiene localidades asociadas";
                        return RedirectToPage("../Error");
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
    }
}
