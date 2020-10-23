using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Teacher("Bob", "Jones", new Classroom(101)));
            people.Add(new Teacher("Sally", "Smith", new Classroom(102)));
            people.Add(new Teacher("Joe", "Johnson", new Classroom(103)));

            people.Add(new Student("Tom", "Winston"));

            foreach (Person person in people)
            {
                Console.WriteLine(person.WriteInfo());

                // If the polymorphic reference is a Student...
                if (person.GetType() == typeof(Student))
                {
                    // Cast the person to a Student (convert it), and call the DoHomework() method.
                    // Trying to cast one object to another type of object other than a base type will likely throw an exception.
                    ((Student)person).DoHomework();
                }
            }


            Person aPerson = new Student("Test", "McTest")
            { MiddleName = "Joe" };

            Console.WriteLine(aPerson.FullName);

        }


    }
}