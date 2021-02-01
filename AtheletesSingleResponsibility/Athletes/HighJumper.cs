using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class HighJumper : Athlete, IHighJump
    {
        public HighJumper(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.HighJump();
        }

        public void HighJump()
        {
            Console.WriteLine($"{AtheleteInformation} doing a SUPPPPPPPPPER HIGH jump");
        }
    }
}
