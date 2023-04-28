using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace AlquileresAutos.Models
{
    public enum Estado
    {
        Disponible,
        Alquilado,
        Inspeccion,
        Inhabilitado
    }
    public class Auto
    {
        public int ID { get; set; }
        public string Patente { get; set; }
        public float CapacidadTanque { get; set; }
        public float Kilometraje { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Detalle { get; set; }
        public int ModeloID { get; set; }
        public Modelo Modelo { get; set; }
        public Estado Estado { get; set; }
    }
}
