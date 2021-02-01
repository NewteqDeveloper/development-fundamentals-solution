using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Bird : Animal
    {
        public override string MakeSound()
        {
            return "Coooo coooo";
        }

        public override string Play()
        {
            return "Bird flies around the block and back";
        }
    }
}
