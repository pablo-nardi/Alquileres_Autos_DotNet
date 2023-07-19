using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class EntidadCrediticia
    {
        public int EntidadCrediticiaID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string nombreEntidadCrediticia { get; set; }
        public string descripcionEntidadCrediticia { get; set; }
        public ICollection<PlanDePago> PlanesDePago { get; set; }
    }
}
