using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCO.Models;

namespace UCO.Data.Interfaces
{
    public interface IArtistaData
    {
        Task<List<Artista>> filtro(string nombre);
        Task<bool> Create(Artista artista);
        Task<bool> Update(Artista artista);
        Task<bool> Delete(int artistaId);
        Task<Artista> ArtistaWhitCanciones(int id);
        Task<List<ArtietaCancionView>> Vistas();
    }
}
