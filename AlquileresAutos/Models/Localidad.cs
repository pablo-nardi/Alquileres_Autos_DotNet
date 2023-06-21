using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class Localidad
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Denominacion { get; set; }
        [Required]
        public int ProvinciaID { get; set; }
        public Provincia Provincia { get; set; }
    }
}
