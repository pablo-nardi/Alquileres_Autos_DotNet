using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class MedioDePago
    {
        public int MedioDePagoID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string nombreMedioDePago { get; set; }
        public string descripcionMedioDePago { get; set; }
        public ICollection<PlanDePago> PlanesDePago { get; set; }
    }
}
