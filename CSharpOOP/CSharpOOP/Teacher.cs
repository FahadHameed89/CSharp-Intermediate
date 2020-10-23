using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Teacher : Person
    {
        // When teachers sleep, energy level goes up by 25, stress goes down by 20.

        public List<Student> Class { get; set; }

        public Classroom Room { get; set; }

        // "Derived" properties are derived from other properties.
        // They have no backing variables themselves.
        public override string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public void AssignHomework()
        {
            foreach (Student student in Class)
            {
                student.DoHomework();
            }
        }

        public override void Sleep()
        {
            EnergyLevel += 25;
            StressLevel -= 20;
        }
        public override void Eat()
        {
            EnergyLevel += 15;
            StressLevel -= 5;
        }
        public Teacher(string firstName, string lastName, Classroom room)
            : base(firstName, lastName)
        {
            Class = new List<Student>();
            Room = room;
        }
        public override string WriteInfo()
        {
            return "This is a teacher!";
        }
    }
}