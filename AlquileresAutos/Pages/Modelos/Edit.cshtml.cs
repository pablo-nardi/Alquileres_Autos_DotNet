using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Data;
using AlquileresAutos.Models;
using Microsoft.Extensions.Options;

namespace AlquileresAutos.Pages.Modelos
{
    public class EditModel : TipoAutoNombrePageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public EditModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Modelo Modelo { get; set; } = default!;
        public string valor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Modelos == null)
                {
                    return NotFound();
                }

                Modelo = await _context.Modelos.FirstOrDefaultAsync(m => m.ID == id);

                if (Modelo == null)
                {
                    return NotFound();
                }

                //ViewData["TipoAutoID"] = new SelectList(_context.TipoAutos, "ID", "ID");
                cargarListaNombreTipoAuto(_context, Modelo.TipoAutoID);
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
                if (id == null)
                {
                    return NotFound();
                }

                var modeloActualizar = await _context.Modelos.FindAsync(id);

                if (modeloActualizar == null)
                {
                    return NotFound();
                }
                if (await TryUpdateModelAsync<Modelo>(
                     modeloActualizar,
                     "Modelo",   // Prefix for form value.
                        s => s.AireAcondicionado,
                        s => s.CantEquipajeChico,
                        s => s.CantEquipajeGrande,
                        s => s.CantPasajeros,
                        s => s.Denominacion,
                        s => s.PrecioPorDia,
                        s => s.Transmision,
                        s => s.TipoAutoID))
                {
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Values.SelectMany(v => v.Errors)
                                                   .Select(e => e.ErrorMessage);
                    throw new Exception(string.Join(", ", errors));
                }

                cargarListaNombreTipoAuto(_context, modeloActualizar.TipoAutoID);
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
