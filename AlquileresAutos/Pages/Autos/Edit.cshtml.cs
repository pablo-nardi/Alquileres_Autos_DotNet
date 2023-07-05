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
using System.Globalization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Pages.Autos
{
    public class EditModel : ModeloNombrePageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        [Display(Name ="Fecha de Compra")]
        public string Fechastr;
        public EditModel(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Auto Auto { get; set; } = default!;

        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            try
            {
                if (id == null || _context.Autos == null)
                {
                    return NotFound();
                }

                Auto = await _context.Autos
                    .FirstOrDefaultAsync(m => m.ID == id);

                if (Auto == null)
                {
                    return NotFound();
                }

                cargarListaModeloNombre(_context, Auto.ModeloID, Auto.SucursalID);

                Fechastr = Auto.FechaCompra.ToString("yyyy-MM-dd");

                //Auto.FechaCompra = DateTime.ParseExact(Fechastr, "yyyy-MM-dd", CultureInfo.InvariantCulture);                


                return Page();
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                return RedirectToPage("../Error");
            }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var autoAModificar = await _context.Autos.FindAsync(id);

                if (autoAModificar == null)
                {
                    return NotFound();
                }

                if (await TryUpdateModelAsync<Auto>(
                    autoAModificar,
                    "Auto",
                    a => a.ID,
                    a => a.Kilometraje,
                    a => a.CapacidadTanque,
                    a => a.Patente,
                    a => a.Detalle,
                    a => a.Estado,
                    a => a.FechaCompra,
                    a => a.ModeloID,
                    a => a.SucursalID))
                {
                    await _context.SaveChangesAsync();
                    return RedirectToPage("./Index");
                }

                cargarListaModeloNombre(_context, autoAModificar.ModeloID);
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
