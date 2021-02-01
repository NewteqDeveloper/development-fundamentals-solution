using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class TripleJumper : Athlete, ITripleJump
    {
        public TripleJumper(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.TripleJump();
        }

        public void TripleJump()
        {
            Console.WriteLine($"{AtheleteInformation} Performing 1 long jump, 2 longer jump, and 3 LOOOOOONG jump");
        }
    }
}
