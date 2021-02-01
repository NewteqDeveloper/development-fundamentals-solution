using AtheletesSingleResponsibility.Athletes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class LongJumper : Athlete, ILongJump
    {
        public LongJumper(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void Compete()
        {
            this.LongJump();
        }

        public void LongJump()
        {
            Console.WriteLine($"{AtheleteInformation} Performing loooooooooong jump");
        }
    }
}
