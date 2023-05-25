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
    public class CreateModel : TipoAutoNombrePageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;

        public CreateModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            // ViewData["TipoAutoID"] = new SelectList(_context.TipoAutos, "ID", "ID");
            cargarListaNombreTipoAuto(_context);
            return Page();
        }

        [BindProperty]
        public Modelo Modelo { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var emptyModelos = new Modelo();

                if (await TryUpdateModelAsync<Modelo>(emptyModelos,
                                                        "Modelo",
                                                        s => s.AireAcondicionado,
                                                        s => s.CantEquipajeChico,
                                                        s => s.CantEquipajeGrande,
                                                        s => s.CantPasajeros,
                                                        s => s.ID,
                                                        s => s.Denominacion,
                                                        s => s.PrecioPorDia,
                                                        s => s.Transmision,
                                                        s => s.TipoAutoID
                                                        ))
                {
                    _context.Modelos.Add(Modelo);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }

                cargarListaNombreTipoAuto(_context, emptyModelos.TipoAutoID);
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
