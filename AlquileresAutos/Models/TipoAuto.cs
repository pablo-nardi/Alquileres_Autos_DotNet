//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class TipoAuto
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Tipo de Auto")]
        public string NombreTipo { get; set; }
    }
}
