namespace Fincas.Common.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Servicio
    {
        [Key]
        public int ServicioID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(60)]
        public string Descripcion { get; set; }

        [JsonIgnore]
        public ICollection<Producto> Productos { get; set; }
    }
}
