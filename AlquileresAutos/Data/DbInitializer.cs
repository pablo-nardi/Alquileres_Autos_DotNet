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
                new Auto{ Patente="AE851AR", capacidadTanque=54, kilometraje=100, fechaCompra=DateTime.Parse("10/07/2021"), detalle="Auto nuevo" },
                new Auto{ Patente="RC855AR", capacidadTanque=54, kilometraje=1000, fechaCompra=DateTime.Parse("10/07/2020"), detalle="Auto nuevo" }
            };

            context.Autos.AddRange(autos);
            context.SaveChanges();

        }
    }
}
