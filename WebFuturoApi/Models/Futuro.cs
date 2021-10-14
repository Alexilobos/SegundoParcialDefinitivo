using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebFuturoApi.Models
{
    public class Futuro
    {
        [Key]
        public string FuturoId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Vision { get; set; }
        [Url]
        [StringLength(1000, MinimumLength = 1, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }

    }
}
