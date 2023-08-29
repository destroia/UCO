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
    public class CancionsController : ControllerBase
    {
        readonly ICancionData Repo;
        public CancionsController(ICancionData repo)
        {
            Repo = repo;
        }

        // GET api/<CancionsController>/5
        [HttpGet("{id}/{name}")]
        public async Task< List<Cancion>> Get(int id ,string name)
        {
            if (name == "0")
            {
                name = "";
            }
            return await Repo.filtro(id,name);
        }

        // POST api/<CancionsController>
        [HttpPost]
        public async Task<ActionResult<bool>> Post(Cancion cancion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await Repo.Create(cancion);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        // PUT api/<CancionsController>/5
        [HttpPut]
        public async Task<ActionResult<bool>> Put(Cancion cancion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await Repo.Update(cancion);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        // DELETE api/<CancionsController>/5
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
