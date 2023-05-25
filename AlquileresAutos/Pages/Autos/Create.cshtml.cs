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
    public class CreateModel : ModeloNombrePageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        [BindProperty]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public CreateModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //ViewData["ModeloID"] = new SelectList(_context.Modelos, "ID", "ID");
            cargarListaModeloNombre(_context);
            return Page();
        }

        [BindProperty]
        public Auto Auto { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                var emptyAuto = new Auto();

                if (await TryUpdateModelAsync<Auto>(emptyAuto,
                    "Auto",
                    a => a.ID,
                    a => a.Kilometraje,
                    a => a.CapacidadTanque,
                    a => a.Patente,
                    a => a.Detalle,
                    a => a.Estado,
                    a => a.FechaCompra,
                    a => a.ModeloID))
                {
                    Auto.FechaCompra = Fecha.Date + TimeSpan.Zero;
                    _context.Autos.Add(Auto);
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }

                cargarListaModeloNombre(_context, emptyAuto.ModeloID);
                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] =ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }
    }
}
