using AlquileresAutos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AlquileresAutos.Services
{
    public class ProvinciaService
    {
        public SelectList ProvincasSL { get; set; }
        public bool HayLocalidadesAsociadas(Provincia provincia)
        {
            if (provincia.Localidades.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public SelectList obtenerProvincias(AlquileresAutos.Data.AlquileresAutosContext context)
        {
            var ProvinciasQuery = from m in context.Provincia
                              orderby m.Denominacion
                              select m;
            ProvincasSL = new SelectList(ProvinciasQuery.AsNoTracking(),
                                        nameof(Provincia.ID),
                                        nameof(Provincia.Denominacion));
            return ProvincasSL;
        }
    }
}
