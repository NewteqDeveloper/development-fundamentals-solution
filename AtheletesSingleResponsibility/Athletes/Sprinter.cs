using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class Sprinter : Athlete, IRunSprints
    {
        public Sprinter(string firstName, string lastName, Gender gender, string country, SprintDistance distance) : base(firstName, lastName, gender, country)
        {
            this.distance = distance;
        }

        private readonly SprintDistance distance;

        public override void Compete()
        {
            this.RunSprints(this.distance);
        }

        public void RunSprints(SprintDistance distance)
        {
            Console.WriteLine($"{AtheleteInformation} Running the sprints for: {(int)distance}m");
        }
    }
}
