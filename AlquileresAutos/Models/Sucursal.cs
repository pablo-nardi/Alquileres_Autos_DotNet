using Microsoft.Build.Framework;

namespace AlquileresAutos.Models
{
    public class Sucursal
    {
        public int ID { get; set; }
        [Required]
        public string Denominacion { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string HoraApertura { get; set; }
        public string HoraCierre { get; set; }
        public int LocalidadID { get; set; }
        public Localidad Localidad { get; set; }
        public ICollection<Auto> Autos { get; set; }
    }
}
