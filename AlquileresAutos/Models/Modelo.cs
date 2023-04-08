using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace AlquileresAutos.Models
{
    public class Modelo
    {
        public int ID { get; set; }
        public int CantEquipajeChico { get; set; }
        public int CantEquipajeGrande { get; set; }
        public int CantPasajeros { get; set; }
        public float PrecioPorDia { get; set; }
        public string Denominacion { get; set; }
        public string Transmision { get; set; }
        public string AireAcondicionado { get; set; }
        public int? TipoAutoID { get; set; }
        public TipoAuto tipoAuto {get; set;}

    }
}
