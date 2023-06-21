using AlquileresAutos.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlquileresAutos.Models;

namespace AlquileresAutos.Pages.Autos
{
    public class ModeloNombrePageModel : PageModel
    {
        public SelectList ModeloNombreSL { get; set; }
        public SelectList EstadoAutoSL { get; set; }
        public SelectList SucursalNombreSL { get; set; }

        public void cargarListaModeloNombre(AlquileresAutosContext _context, object selectModelo = null, object selectSucursal = null)
        {
            var modeloQuery = from m in _context.Modelos
                              orderby m.Denominacion
                              select m;
            var SucursalQuery = from s in _context.Sucursal
                                   select s;

            ModeloNombreSL = new SelectList(modeloQuery.AsNoTracking(),
                nameof(Modelo.ID),
                nameof(Modelo.Denominacion),
                selectModelo);

            SucursalNombreSL = new SelectList(SucursalQuery.AsNoTracking(),
                nameof(Sucursal.ID),
                nameof(Sucursal.Denominacion),
                selectSucursal);

            EstadoAutoSL = new SelectList(Enum.GetValues(typeof(Estado)).Cast<Estado>().ToList());
        }
    }
}
