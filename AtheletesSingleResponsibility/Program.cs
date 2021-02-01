using AtheletesSingleResponsibility.Athletes;
using AtheletesSingleResponsibility.Data;
using System;

namespace AtheletesSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var athlete in Database.Atheletes)
            {
                athlete.Compete();
            }

            Console.ReadKey();
        }
    }
}
