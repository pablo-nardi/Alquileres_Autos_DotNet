using System.ComponentModel.DataAnnotations;

namespace AlquileresAutos.Models
{
    public class PlanDePago
    {
        public int PlanDePagoID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string NombrePlanDePago { get; set; }
        public string DescripcionPlanDePago { get; set; }
        public int IDEntidadCrediticia { get; set; }
        public EntidadCrediticia EntidadCrediticia { get; set; }
        public int IDMedioDePago { get; set; }
        public MedioDePago MedioDePago { get; set; }

    }
}
