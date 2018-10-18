namespace Fincas.Common.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Servicio
    {
        [Key]
        public int ServicioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}
