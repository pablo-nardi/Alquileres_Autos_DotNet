using AlquileresAutos.Models;

namespace AlquileresAutos.Data
{
    public class DbInitializer
    {
        public static void Initialize(AlquileresAutosContext context)
        {
            if (context.Autos.Any()){
                return;
            }

            var autos = new Auto[]
            {
                new Auto{ Patente="AE851AR", CapacidadTanque=54, Kilometraje=100, FechaCompra=DateTime.Parse("10/07/2021"), Detalle="Auto nuevo" },
                new Auto{ Patente="RC855AR", CapacidadTanque=54, Kilometraje=1000, FechaCompra=DateTime.Parse("10/07/2020"), Detalle="Auto nuevo" }
            };

            context.Autos.AddRange(autos);
            context.SaveChanges();

        }
    }
}
