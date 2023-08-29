using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCO.Models
{
    public class ArtietaCancionView
    {
        public int IdArtista { get; set; }
        public int IdCancion { get; set; }
        public string  NombreArtista { get; set; }
        public string Pais { get; set; }
        public string CasaDisquera { get; set; }
        public string NombreCancion { get; set; }
        public string Duracion { get; set; }
    }
}
