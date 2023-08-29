using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UCO.Data.Interfaces;
using UCO.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UCO.Api.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ArtistasController : ControllerBase
    {
        readonly IArtistaData Repo;
        public ArtistasController(IArtistaData repo)
        {
            Repo = repo;
        }
        // GET: api/<ArtistasController>
        [HttpGet]
        public async Task<List<ArtietaCancionView>> GetVista()
        {
            return await Repo.Vistas();
        }

        [HttpGet("{id}")]
        public async Task<Artista> ArtistaWhitCanciones(int id)
        {
            return await Repo.ArtistaWhitCanciones(id);
        }
        // GET api/<ArtistasController>/5
        [HttpGet("{name}")]
        public async Task<List<Artista>> Get(string name = "")
        {
            if (name == "0")
            {
                name = "";
            }
            return await Repo.filtro(name);
        }

        // POST api/<ArtistasController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post(Artista art)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await Repo.Create(art);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // PUT api/<ArtistasController>/5
        [HttpPut]
        public async Task<ActionResult<bool>>  Put(Artista artista)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await Repo.Update(artista);
            if (result )
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        // DELETE api/<ArtistasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await Repo.Delete(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
