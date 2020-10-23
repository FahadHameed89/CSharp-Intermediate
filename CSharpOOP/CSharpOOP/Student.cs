using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpOOP
{
    class Student : Person
    {
        // When students sleep, energy level goes up by 35, stress goes down by 30.

        public void DoHomework()
        {
            EnergyLevel -= 20;
            StressLevel += 25;
        }

        public override void Sleep()
        {
            EnergyLevel += 35;
            StressLevel -= 30;
        }

        public override void Eat()
        {
            EnergyLevel += 15;
            StressLevel -= 10;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EnergyLevel = 100;
            StressLevel = 0;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Stress:{StressLevel} Energy:{EnergyLevel}";
        }
    }
}