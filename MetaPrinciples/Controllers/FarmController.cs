using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaPrinciples.Animals;
using MetaPrinciples.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MetaPrinciples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    /*
     * Biggest key to API is consistency, ensure constitency in this API
     * 
     * The 4 princples of API are:
     *  1. Simplicity
	    2. Expressiveness
	    3. Extensibility
	    4. Consistency
     * 
     * Include missing animals in this farm
     */
    public class FarmController : ControllerBase
    {
        private readonly IAnimalService animalService;

        public FarmController(IAnimalService animalService)
        {
            this.animalService = animalService;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetAllAnimals(AnimalType? type = null)
        {
            if (type == null)
            {
                return Ok(animalService.Animals());
            }
            else
            {
                return Ok(animalService.AnimalOfType(type.Value));
            }
        }

        [HttpGet]
        [Route("sound")]
        public IActionResult AnimalSound(AnimalType type)
        {
            return Ok(animalService.AnimalSound(type));
        }

        [HttpGet]
        [Route("play")]
        public IActionResult PlayWithAnimal(int id)
        {
            return Ok(animalService.PlayWithAnimal(id));
        }
    }
}
