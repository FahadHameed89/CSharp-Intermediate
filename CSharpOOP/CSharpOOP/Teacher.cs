using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Student> Class { get; set; }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Class = new List<Student>();
        }
    }
}
