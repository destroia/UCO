using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCO.Models
{
    public class Artista
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50,MinimumLength =2,ErrorMessage ="El nombre debe ser minimo de 2 caracteres maximo de 50")]
        public string Nombre { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El pais debe ser minimo de 2 caracteres maximo de 50")]
        public string Pais { get; set; }
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La Casa disquera debe ser minimo de 2 caracteres maximo de 50")]
        public string CasaDisquera { get; set; }
        public List<Cancion> Cancions { get; set; }
    }
}
