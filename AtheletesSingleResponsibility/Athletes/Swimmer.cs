using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class Swimmer : Athlete, ISwim
    {
        private readonly SwimDistance distance;

        public Swimmer(string firstName, string lastName, Gender gender, string country, SwimDistance distance) : base(firstName, lastName, gender, country)
        {
            this.distance = distance;
        }

        public override void Compete()
        {
            this.Swim(this.distance);
        }

        public void Swim(SwimDistance distance)
        {
            Console.WriteLine($"{AtheleteInformation} - swimming as fast as I can for {(int) distance}");
        }
    }
}
