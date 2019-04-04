using System.ComponentModel.DataAnnotations;

namespace Parcial1._1.Models
{
    public enum TipoEstado
    {
        Activo,
        Inactivo
    }
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }             //damos prop y tab tab seguido y nos da toda esa propiedad

        [Required]                                      //le damos control Punto en required y elimina
        [Display(Name = "Product Name")]
        public string Nombre { get; set; }

        public decimal Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }

        [Required]
        public TipoUnidad Unidad { get; set; }

        [Required]
        public TipoEstado Estado { get; set; }


    }
}