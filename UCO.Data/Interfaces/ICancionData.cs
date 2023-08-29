using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCO.Models;

namespace UCO.Data.Interfaces
{
    public interface ICancionData
    {
        Task<bool> Create(Cancion cancion);
        Task<bool> Update(Cancion cancion);
        Task<bool> Delete (int cancionId);
        Task<List<Cancion>> filtro(int id ,string nombre);
    }
}
