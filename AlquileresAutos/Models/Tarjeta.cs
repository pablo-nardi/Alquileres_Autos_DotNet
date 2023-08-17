using Microsoft.Build.Framework;

namespace AlquileresAutos.Models
{
    public class Tarjeta
    {
        
        public int TarjetaID { get; set; }
        [Required]
        public int NumeroTarjeta { get; set; }
        [Required]
        public string TitularTarjeta { get; set; }
        [Required]
        public int DniTitularTarjeta { get; set; }
        [Required]
        public string MesVencimientoTarjeta { get; set; }
        [Required]
        public string AnioVencimientoTarjeta { get; set; }

    }
}
