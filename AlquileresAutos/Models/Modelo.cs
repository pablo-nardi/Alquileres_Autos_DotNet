using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace AlquileresAutos.Models
{
    public class Modelo
    {
        public int ID { get; set; }
        public int cantEquipajeChico { get; set; }
        public int cantEquipajeGrande { get; set; }
        public int cantPasajeros { get; set; }
        public float precioPorDia { get; set; }
        public string denominacion { get; set; }
        public string transmision { get; set; }
        public string aireAcondicionado { get; set; }

    }
}
