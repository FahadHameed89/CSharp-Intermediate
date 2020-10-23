using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Teacher : Person
    {
        // When students sleep, energy level goes up by 35, stress goes down by 30.

        public List<Student> Class { get; set; }

        public Classroom Room { get; set; }

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
            StressLevel -= 10;
        }

        public Teacher(string firstName, string lastName, Classroom room)
        {
            FirstName = firstName;
            LastName = lastName;

            Class = new List<Student>();
            Room = room;
        }
    }
}