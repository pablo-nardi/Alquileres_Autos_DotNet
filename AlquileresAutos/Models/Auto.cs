using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresAutos.Models
{
    public enum Estado
    {
        Disponible,
        Alquilado,
        Inspeccion,
        Inhabilitado
    }
    public class Auto
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Patente { get; set; }
        [Required]
        [Display(Name = "Capacidad del Tanque")]
        [Range(10, 500)]
        public float CapacidadTanque { get; set; }
        [Required]
        public float Kilometraje { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Compra")]
        public DateTime FechaCompra { get; set; }
        public string Detalle { get; set; }
        [Required]
        public int ModeloID { get; set; }
        public Modelo Modelo { get; set; }
        public Estado Estado { get; set; }
        public int SucursalID { get; set; }
        public Sucursal Sucursal { get; set; }
    }
}
