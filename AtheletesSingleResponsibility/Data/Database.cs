using AtheletesSingleResponsibility.Athletes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Data
{
    public static class Database
    {
        public static List<Athlete> Atheletes = new List<Athlete>
        {
            new HighJumper("High", "Jumper", Gender.Male, "ZA"),
            new HighJumper("Girl", "Jumper", Gender.Female, "US"),
            new LongJumper("Super", "Long", Gender.Male, "ZA"),
            new TripleJumper("Mike", "Triple", Gender.Male, "UK"),
            new Sprinter("Usain", "Bolt", Gender.Male, "JM", SprintDistance.OneHundred),
            new Sprinter("Caster", "Semenya", Gender.Female, "ZA", SprintDistance.TwoHundred),
            new RelayRunner("Newteq", "Developer", Gender.Male, "ZA"),
            new Swimmer("Fast", "Swimm", Gender.Female, "NZ", SwimDistance.TwoHundred),
            new Swimmer("Michael", "Phelps", Gender.Male, "US", SwimDistance.OneHundred),
        };
    }
}
