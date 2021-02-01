using MetaPrinciples.Animals;
using System.Collections.Generic;

namespace MetaPrinciples.Services
{
    public interface IAnimalService
    {
        IList<Animal> AnimalOfType(AnimalType type);
        IList<Animal> Animals();
        string AnimalSound(AnimalType type);
        string PlayWithAnimal(int id);
    }
}