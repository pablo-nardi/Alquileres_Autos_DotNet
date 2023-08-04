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
        [Required]
        public int CantidadDeCuotas { get; set; }
        [Required]
        public float TotalAPagar { get; set; }
        [Required]
        public float PrecioPorCuota { get; set; }
        public int CantidadCuotasPagas { get; set; }
        [Required]
        public DateTime FechaInicioPlan { get; set; }
        public DateTime FechaUltimoPago { get; set; }
        [Required]
        public int EntidadCrediticiaID { get; set; }
        public EntidadCrediticia EntidadCrediticia { get; set; }
        [Required]
        public int MedioDePagoID { get; set; }
        public MedioDePago MedioDePago { get; set; }

    }
}
