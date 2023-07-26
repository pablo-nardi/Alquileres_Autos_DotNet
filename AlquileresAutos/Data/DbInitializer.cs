using AlquileresAutos.Models;

namespace AlquileresAutos.Data
{
    public class DbInitializer
    {
        public static void Initialize(AlquileresAutosContext context)
        {
            /*
             Revisar el tema con los planes de pago
            porque puede que apunte a claves foraneas que ya no existen
             */

            if (!context.Autos.Any() ) 
            {
                var autos = new Auto[]
                {
                    new Auto{ Patente="AE851AR", CapacidadTanque=54, Kilometraje=100, FechaCompra=DateTime.Parse("10/07/2021"), Detalle="Auto nuevo" },
                    new Auto{ Patente="RC855AR", CapacidadTanque=54, Kilometraje=1000, FechaCompra=DateTime.Parse("10/07/2020"), Detalle="Auto nuevo" }
                };
                context.Autos.AddRange(autos);
            }
            if (!context.MediosDePagos.Any())
            {
                var medioDePago = new MedioDePago[]
                {
                    new MedioDePago
                    {
                        nombreMedioDePago = "Ahora 12", descripcionMedioDePago="Plan 12 cuotas con subsidio del gobierno"
                    },
                    new MedioDePago
                    {
                        nombreMedioDePago = "12 cuotas", descripcionMedioDePago="Plan generico para 12 cuotas"
                    }
                };
               
                context.MediosDePagos.AddRange(medioDePago);
            }
            if (!context.EntidadesCrediticias.Any())
            {
                var entidadCrediticia = new EntidadCrediticia[]
                {
                    new EntidadCrediticia
                    {
                        nombreEntidadCrediticia = "Banco Macro", descripcionEntidadCrediticia="Banco Argentino"
                    },
                    new EntidadCrediticia
                    {
                        nombreEntidadCrediticia = "Banco Santander", descripcionEntidadCrediticia="Banco Argentino"
                    }
                };
                context.EntidadesCrediticias.AddRange(entidadCrediticia);
            }
            if (!context.PlanesDePagos.Any())
            {
                var planesDePago = new PlanDePago[]
                {
                    new PlanDePago
                    {
                        NombrePlanDePago = "Plan normal Bancos", EntidadCrediticiaID = 3, MedioDePagoID = 1
                    },
                    new PlanDePago
                    {
                        NombrePlanDePago = "Otro Plan normal Bancos", EntidadCrediticiaID = 4, MedioDePagoID = 1
                    }
                };
                context.PlanesDePagos.AddRange(planesDePago);

            }
            context.SaveChanges();
        }
    }
}
