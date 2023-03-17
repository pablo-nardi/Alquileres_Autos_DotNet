using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace AlquileresAutos.Models
{
    public class Auto
    {
        public int ID { get; set; }
        public string Patente { get; set; }
        public float capacidadTanque { get; set; }
        public float kilometraje { get; set; }
        public DateTime fechaCompra { get; set; }
        public string detalle { get; set; }
    }
}
