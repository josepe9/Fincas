namespace Fincas.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Display(Name = "Servicio")]
        public int ServicioId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [DataType(DataType.Currency)]
        //[Column(TypeName = "money")]
        [DisplayFormat(DataFormatString = "$ {0:#,0}")]
        public Decimal Precio { get; set; }

        public bool Disponible { get; set; }

        [DataType(DataType.Date)]
        //DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayFormat(DataFormatString = "{0:D}")]
        public DateTime Publicado { get; set; }

        [NotMapped]
        [Display(Name = "Dias publicado")]
        public int Diaspublicado { get { return (((DateTime.Now.Year - Publicado.Year)*365)+ 
                    ((DateTime.Now.Month - Publicado.Month) * 30)+(DateTime.Now.Day - Publicado.Day)); } }

        public Servicio Servicio { get; set; }
    }
}
