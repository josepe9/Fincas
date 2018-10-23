namespace Fincas.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int ServicioId { get; set; }

        public Decimal Precio { get; set; }

        public bool Disponible { get; set; }

        public DateTime Publicado { get; set; }
    }
}
