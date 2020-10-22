using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher mathTeacher = new Teacher("Bob", "Jones");

            Student joe = new Student("Joe", "Smith");
            Student sally = new Student("Sally", "Howard");

            mathTeacher.Class.Add(joe);
            mathTeacher.Class.Add(sally);

            Console.WriteLine($"joe variable: {joe.FirstName} {joe.LastName}");
            Console.WriteLine($"First Student: {mathTeacher.Class[0].FirstName} {mathTeacher.Class[0].LastName}");

            joe.LastName = "Johnson";

            Console.WriteLine($"joe variable: {joe.FirstName} {joe.LastName}");
            Console.WriteLine($"First Student: {mathTeacher.Class[0].FirstName} {mathTeacher.Class[0].LastName}");

            joe = new Student("Joe", "Smith");

            Console.WriteLine($"joe variable: {joe.FirstName} {joe.LastName}");
            Console.WriteLine($"First Student: {mathTeacher.Class[0].FirstName} {mathTeacher.Class[0].LastName}");

            mathTeacher.Class[0].LastName = "Shepard";

            Console.WriteLine($"joe variable: {joe.FirstName} {joe.LastName}");
            Console.WriteLine($"First Student: {mathTeacher.Class[0].FirstName} {mathTeacher.Class[0].LastName}");
        }
    }
}