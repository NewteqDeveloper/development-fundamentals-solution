using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class RelayRunner : Athlete, IRelayRunner
    {
        public RelayRunner(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.RunRelay();
        }

        public void RunRelay()
        {
            Console.WriteLine($"{AtheleteInformation} Running Relay");
        }
    }
}
