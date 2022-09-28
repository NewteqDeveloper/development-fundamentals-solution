using AtheletesSingleResponsibility.Athletes;
using AtheletesSingleResponsibility.Data;
using System;
using AtheletesSingleResponsibility.Athletes.Interfaces;

namespace AtheletesSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphic approach
            foreach(var athlete in Database.Atheletes)
            {
                athlete.Compete();
            }

            // non-polymorphic approach
            // foreach (var athlete in Database.Atheletes)
            // {
            //     if (athlete is IHighJump highJumper)
            //     {
            //         highJumper.HighJump();
            //     }
            // }

            Console.ReadKey();
        }
    }
}
