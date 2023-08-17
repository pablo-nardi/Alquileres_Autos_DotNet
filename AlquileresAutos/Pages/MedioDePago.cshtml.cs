using AlquileresAutos.Data;
using AlquileresAutos.Models;
using AlquileresAutos.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Security.Policy;

namespace AlquileresAutos.Pages
{
    
    public class MedioDePagoModel : PageModel
    {
        private readonly AlquileresAutos.Data.AlquileresAutosContext _context;
        public Auto Auto { get; set; }
        [BindProperty]
        public PlanDePago PlanDePago { get; set; }
        [BindProperty]
        public Tarjeta Tarjeta { get; set; }
        public IList<MedioDePago> MediosDePago { get; set; }
        public IList<EntidadCrediticia> EntidaddesCrediticias { get; set; }
        public int anioSiguienteAlActual = DateTime.Now.Year + 1;
        public Alquiler Alquiler { get; set; }

        public MedioDePagoModel(AlquileresAutosContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(int? autoId)
        {
            try
            {
                if (autoId != null)
                {
                    BuscarAuto(autoId);
                    CargarAlquiler();
                    ManejoDeSesion.JsonSet(HttpContext.Session, "alquiler", Alquiler);
                }
                MediosDePago = await _context.MediosDePagos.ToListAsync();
                EntidaddesCrediticias = await _context.EntidadesCrediticias.ToListAsync();
                PlanDePago = new PlanDePago();
                Tarjeta = new Tarjeta();

            }
            catch(Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException.Message;
                RedirectToPage("./Error");
            }
           
        }
        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                PlanDePago.NombrePlanDePago = "Prueba nombre";
                PlanDePago.PrecioPorCuota = 
                    PlanDePago.TotalAPagar / PlanDePago.CantidadDeCuotas;
                PlanDePago.FechaInicioPlan = DateTime.Now;
                
                _context.Add(PlanDePago);
                _context.Add(Tarjeta);
                await _context.SaveChangesAsync();
                return RedirectToPage("./DatosCliente");
            }
            catch(Exception ex)
            {
                //TempData["ErrorMessage"] = ex.InnerException.Message;
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToPage("./Error");
            }
        }
        private async void BuscarAuto(int? autoId)
        {
            Auto = await _context.Autos.FindAsync(autoId);
        }
        private void CargarAlquiler()
        {
            Alquiler = new Alquiler
            {
                Auto = Auto
            };
        }
    }
}
