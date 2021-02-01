using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Services
{
    public interface IReportingService
    {
        string AnimalCount(AnimalType animalType);
    }
}
