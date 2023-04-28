using AlquileresAutos.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Modelos
{
    public class TipoAutoNombrePageModel : PageModel
    {
        public SelectList TipoAutoNombreSL { get; set; }

        public void cargarListaNombreTipoAuto(AlquileresAutosContext _context, object selectDepartment = null)
        {
            var tipoAutoQuery = from t in _context.TipoAutos
                                orderby t.NombreTipo
                                select t;

            TipoAutoNombreSL = new SelectList(tipoAutoQuery.AsNoTracking(),
                nameof(TipoAuto.ID),
                nameof(TipoAuto.NombreTipo), 
                selectDepartment);
        }
    }
}
