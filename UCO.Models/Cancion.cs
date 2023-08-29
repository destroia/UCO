using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCO.Models
{
    public class Cancion
    {
        [Key]
        public int Id { get; set; }
        public int ArtistaId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage ="El nombre debe de ser minimo de dos caracteres maximo de 50 caracteres")]
        public string Nombre { get; set; }
        [Required]
        public string Duracion { get; set; }
    }
}
