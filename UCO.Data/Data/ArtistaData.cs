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
    public class ArtistaData : IArtistaData
    {
        readonly ContextDbUCO DB;
        public ArtistaData(ContextDbUCO db)
        {
            DB = db;
        }
        string sql = " @Id, @Nombre, @Pais, @CasaDisquera";

        SqlParameter[] SetParametros(Artista artista)
        {
            
            SqlParameter param = new SqlParameter("@Id", artista.Id);
            SqlParameter param2 = new SqlParameter("@Nombre", artista.Nombre);
            SqlParameter param3 = new SqlParameter("@Pais", artista.Pais);
            SqlParameter param4 = new SqlParameter("@CasaDisquera", artista.CasaDisquera);

            SqlParameter[] parames = new SqlParameter[] { param, param2, param3, param4};

            return parames;

        }
        public async Task<bool> Create(Artista artista)
        {
            var parameters = SetParametros(artista);

            var resulte = await DB.Database.ExecuteSqlRawAsync("CreateArtistaSP" + sql, parameters);
            
            return resulte  == 1 ?true :  false;
        }

        public async Task<bool> Delete(int artistaId)
        {
            SqlParameter param = new SqlParameter("@Id", artistaId);
            await DB.SaveChangesAsync();
            var result = await DB.Database.ExecuteSqlRawAsync("DeleteArtistaSP @Id", param);

            if (result == 1)
            {
                return true;
            }
            return false;
        }

        public async Task<List<Artista>> filtro(string nombre)
        {
            SqlParameter param = new SqlParameter("@Nombre", nombre);
            
            var result = await DB.Artistas.FromSqlRaw("FiltrarArtistaPS @Nombre", param).ToListAsync();
            return result;
        }

        public async Task<bool> Update(Artista artista)
        {
            var parameters = SetParametros(artista);

           
            var resulte =  await DB.Database.ExecuteSqlRawAsync("UpdateArtistaSP" + sql, parameters);
            if (resulte == 1)
            {
                await DB.SaveChangesAsync();
            }
            return resulte == 1 ? true : false;
        }

        public async Task<List<ArtietaCancionView>> Vistas()
        {
            return await DB.ArtietaCancionView.ToListAsync();
        }

        public async  Task<Artista> ArtistaWhitCanciones(int id)
        {
            SqlParameter param = new SqlParameter("@Id", id);

            var result = await DB.Artistas.FromSqlRaw("BuscarById @Id", param).ToListAsync();

            if (result[0] != null)
            {
                result[0].Cancions = await DB.Cancions.FromSqlRaw("BuscarByArtistaId @Id", param).ToListAsync();
            }

            return result[0];
        }
    }
}
