using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Database
{
    public static class Data
    {

        public static IList<Animal> Animals = new List<Animal>
            {
                new Cat
                {
                    Name = "Kitty",
                    Id = 1,
                },
                new Dog
                {
                    Name = "Doggo",
                    Id = 2,
                },
                new Dog
                {
                    Name = "Max",
                    Id = 3,
                },
                new Dog
                {
                    Name = "Billy",
                    Id = 4,
                },
                new Cat
                {
                    Name = "Ginger",
                    Id = 5,
                },
                new Cow
                {
                    Name = "Cowie",
                    Id = 6,
                },
                new Cow
                {
                    Name = "Milky",
                    Id = 7,
                },
                new Sheep
                {
                    Name = "Ba ba sheep",
                    Id = 8,
                },
                new Chicken
                {
                    Name = "Chucky",
                    Id = 9,
                },
                new Bird
                {
                    Name = "Tweety",
                    Id = 10,
                }
            };

        public static Func<Animal, bool> GetAnimalByTypeFunc(AnimalType animalType)
        {
            return x => x.GetType().Name.Equals(animalType.ToString(), StringComparison.InvariantCultureIgnoreCase);
        }

        public static Dictionary<AnimalType, IList<Animal>> AnimalDictionary()
        {
            var animals = Animals;
            var animalDictionary = new Dictionary<AnimalType, IList<Animal>>();

            var listOfDogs = new List<Animal>();
            var listOfCats = new List<Animal>();
            var listOfCows = new List<Animal>();
            var listOfSheep = new List<Animal>();
            var listOfChickens = new List<Animal>();
            var listOfBirds = new List<Animal>();

            foreach (var animal in animals)
            {
                switch (animal)
                {
                    case Dog dog:
                        listOfDogs.Add(dog);
                        break;
                    case Cat cat:
                        listOfCats.Add(cat);
                        break;
                    case Cow cow:
                        listOfCows.Add(cow);
                        break;
                    case Sheep sheep:
                        listOfSheep.Add(sheep);
                        break;
                    case Chicken chicken:
                        listOfChickens.Add(chicken);
                        break;
                    case Bird bird:
                        listOfBirds.Add(bird);
                        break;
                }
            }

            animalDictionary.Add(AnimalType.Dog, listOfDogs);
            animalDictionary.Add(AnimalType.Cat, listOfCats);
            animalDictionary.Add(AnimalType.Cow, listOfCows);
            animalDictionary.Add(AnimalType.Chicken, listOfChickens);
            animalDictionary.Add(AnimalType.Sheep, listOfSheep);
            animalDictionary.Add(AnimalType.Bird, listOfBirds);

            return animalDictionary;
        }
    }
}
