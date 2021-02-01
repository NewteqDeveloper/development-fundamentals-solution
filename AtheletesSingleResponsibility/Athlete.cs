using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility
{
    public enum SprintDistance
    {
        OneHundred = 100,
        TwoHundred = 200,
        FourHundred = 400
    }

    public enum SwimDistance
    {
        Fifty = 50,
        OneHundred = 100,
        TwoHundred = 200
    }

    public enum Gender
    {
        Male,
        Female
    }
    
    public abstract class Athlete : IAthlete
    {
        public Athlete(string firstName, string lastName, Gender gender, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Country = country;
        }
        
        public string FirstName { get; }
        public string LastName { get; }
        public string Country { get; }
        public Gender Gender { get; }

        public string AtheleteInformation => $"{FirstName} {LastName} ({Gender}), from {Country} is now performing :: ";

        public abstract void Compete();
    }
}
