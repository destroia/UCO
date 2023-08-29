using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCO.Data.Interfaces;
using UCO.Models;

namespace UCO.Data.Data
{
    public class CancionData : ICancionData
    {
        readonly ContextDbUCO DB;
        public CancionData(ContextDbUCO db)
        {
            DB = db;
        }
        string sql = " @Id, @ArtistaId, @Nombre, @Duracion";
        SqlParameter[] SetParametros(Cancion cancion)
        {

            SqlParameter param = new SqlParameter("@Id", cancion.Id);
            SqlParameter param2 = new SqlParameter("@ArtistaId", cancion.ArtistaId);
            SqlParameter param3 = new SqlParameter("@Nombre", cancion.Nombre);
            SqlParameter param4 = new SqlParameter("@Duracion", cancion.Duracion);

            SqlParameter[] parames = new SqlParameter[] { param, param2, param3, param4 };

            return parames;

        }
        public async Task<bool> Create(Cancion cancion)
        {
            var parameters = SetParametros(cancion);

            var resulte = await DB.Database.ExecuteSqlRawAsync("CreateCancionSP" + sql, parameters);

            return resulte == 1 ? true : false;
        }

        public async Task<bool> Delete(int cancionId)
        {

            SqlParameter param = new SqlParameter("@Id", cancionId);
            var resulte = await DB.Database.ExecuteSqlRawAsync("DeleteCancionSP @Id", param);

            return resulte == 1 ? true : false;
        }

        public async Task<bool> Update(Cancion cancion)
        {
            var parameters = SetParametros(cancion);

            var resulte = await DB.Database.ExecuteSqlRawAsync("UpdateCancionSP" + sql, parameters);

            return resulte == 1 ? true : false;
        }

        public async Task<List<Cancion>> filtro(int id,string nombre)
        {
            SqlParameter param2 = new SqlParameter("@Nombre", nombre);
            SqlParameter param1 = new SqlParameter("@Id", id);
            SqlParameter[] parameters = new SqlParameter[] { param1, param2 };

            var resulte = await DB.Cancions.FromSqlRaw("FiltrarCancionPS @Id, @Nombre", parameters).ToListAsync();

            return resulte;
        }
    }
}
