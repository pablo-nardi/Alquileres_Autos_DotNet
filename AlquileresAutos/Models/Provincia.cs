using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresAutos.Models
{
    public class Provincia
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Denominacion { get; set; }
        public ICollection<Localidad> Localidades { get; set; }
    }
}
