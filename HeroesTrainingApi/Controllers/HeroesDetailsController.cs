﻿using Microsoft.AspNetCore.Mvc;
using HeroesTraining.BL;
using HeroesTraining.DTO;


namespace HeroesTrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IHeroesBL _heroesBL;

        // GET: api/<ValuesController>
        [HttpGet]
        public  async Task <ActionResult< IEnumerable<HeroesDTO>>> Get()
        {
            try
            {
                return Ok(await _heroesBL.GetHeroes());
            }
            catch(Exception ex)
            {
                //Log
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<HeroesDTO>> void Put(int id, [FromBody] HeroesDTO heroesDTO)
        {
            try 
	        {
                if(id!=heroesDTO.HeroesId)   
                    return BadRequest("Heroes ID mismatch");

                var HeroesToUpdate=_heroesBL.PutHeroes(int id, [FromBody] HeroesDTO heroesDTO)
		
	        }
	        catch (Exception)
        	{

		        return StatusCode(StatusCodes.Status500InternalServerError,"Error Update Heros")
        	}
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
