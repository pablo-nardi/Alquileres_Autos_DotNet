namespace AlquileresAutos.Models
{
    public enum EstadoAlquiler
    {
        Abierto,
        Anulado,
        Cancelado,
        Cerrado,
        Inspeccion,
        Reservado
    }
    public class Alquiler
    {
        public int AlquilerID { get; set; }
        public float ImporteAcordadoConCliente { get; set; }
        public float CostoPorDaños { get; set; }
        public float CostoPorDevolucionTardia { get; set; }
        public float PrecioDiario { get; set; }
        public Estado Estado { get; set; }
        public DateTime FechaHoraRetiroPrevista { get; set; }
        public DateTime FechaHoraDevolucionPrevista { get; set; }
        public DateTime FechaHoraRetiroReal { get; set; }
        public DateTime FechaHoraDevolucionReal { get; set; }
        public int IDAuto { get; set; }
        public int IDEntidadCrediticia { get; set; }
        public int IDMedioDePago { get; set; }
        public int IDModelo { get; set; }
        public int IDPlanDePago { get; set; }
        public int IDSucursal { get; set; }
        public int IDTipoAuto { get; set; }
        public Auto Auto { get; set; }
        public Modelo Modelo { get; set; }
        public TipoAuto TipoAuto { get; set; }
        public EntidadCrediticia EntidadCrediticia { get; set; }
        public MedioDePago MedioDePago { get; set; }
        public PlanDePago PlanDePago { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
