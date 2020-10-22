using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int EnergyLevel { get; set; }
        public int StressLevel { get; set; }

        public void DoHomework()
        {
            EnergyLevel -= 20;
            StressLevel += 25;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EnergyLevel = 100;
            StressLevel = 0;
        }
    }
}
