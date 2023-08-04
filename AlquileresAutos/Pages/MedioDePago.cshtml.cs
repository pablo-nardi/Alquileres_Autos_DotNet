using AlquileresAutos.Data;
using AlquileresAutos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AlquileresAutos.Pages
{
    
    public class MedioDePagoModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public Auto Auto { get; set; }
        public IList<MedioDePago> MediosDePago { get; set; }
        public IList<EntidadCrediticia> EntidaddesCrediticias { get; set; }
        public int anioSiguienteAlActual = DateTime.Now.Year + 1;


        public MedioDePagoModel(AlquileresAutosContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(int? id)
        {
            if (id != null)
            {
                Auto = await _context.Autos.FindAsync(id);
            }
            MediosDePago = await _context.MediosDePagos.ToListAsync();
            EntidaddesCrediticias = await _context.EntidadesCrediticias.ToListAsync();
        }
    }
}
