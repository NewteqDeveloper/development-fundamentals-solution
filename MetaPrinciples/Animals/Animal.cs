using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public abstract class Animal
    {
        public int Id { get; set; }
        
        public string Type => this.GetType().Name;

        public string Name { get; set; }

        public abstract string MakeSound();

        public virtual string Play()
        {
            return "This animal does not know how to play";
        }
    }
}
