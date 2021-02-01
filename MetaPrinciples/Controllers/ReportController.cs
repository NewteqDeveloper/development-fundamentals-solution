using MetaPrinciples.Animals;
using MetaPrinciples.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportingService reportingService;

        public ReportController(IReportingService reportingService)
        {
            this.reportingService = reportingService;
        }

        [HttpGet]
        [Route("animalType")]
        public IActionResult HowManyOfAnimalType(AnimalType animalType)
        {
            return Ok(reportingService.AnimalCount(animalType));
        }
    }
}
