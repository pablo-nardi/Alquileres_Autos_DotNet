using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class Modelo
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Cant. Equipaje Chico")]
        [Range(0,10)]
        public int CantEquipajeChico { get; set; }
        [Required]
        [Display(Name = "Cant. Equipaje Grande")]
        [Range(0, 5)]
        public int CantEquipajeGrande { get; set; }
        [Required]
        [Display(Name = "Cant. de Pasajeros")]
        [Range(0, 8)]
        public int CantPasajeros { get; set; }
        [Required]
        [Display(Name = "Precio por Dia")]
        public float PrecioPorDia { get; set; }
        [Required]
        public string Denominacion { get; set; }
        [Required]
        public string Transmision { get; set; }
        [Required]
        [Display(Name = "Aire Acondicionado")]
        public string AireAcondicionado { get; set; }
        public int? TipoAutoID { get; set; }
        [Required]
        [Display(Name = "Tipo de Auto")]
        public TipoAuto tipoAuto {get; set;}

    }
}
