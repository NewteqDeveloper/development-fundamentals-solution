using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class HurdleRunner : Athlete, IHurdleRunner
    {
        public HurdleRunner(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.RunHurdles();
        }

        public void RunHurdles()
        {
            Console.WriteLine($"{AtheleteInformation} Running Hurdles");
        }
    }
}
