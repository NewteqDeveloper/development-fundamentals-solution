using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Bark!";
        }

        public override string Play()
        {
            return "Dog fetches stick";
        }
    }
}
