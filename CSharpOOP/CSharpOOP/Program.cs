using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpOOP
{
    class Person
    {
        public enum GenderValue
        {
            Male,
            Female,
            NotStated
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public GenderValue Gender { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // In-class practice 2.
            List<Person> personList = SeedPersonList();

            Console.WriteLine($"The number of females in the list: {personList.Where(x => x.Gender == Person.GenderValue.Female).Count()}.");
            Console.WriteLine($"The average number of characters in first names: {personList.Select(x => x.FirstName.Length).Average()}.");
            Console.WriteLine($"The full name of the youngest person: {personList.Where(x => x.DateOfBirth == personList.Select(y => y.DateOfBirth).Max()).Select(x => x.FirstName + " " + x.LastName).Single()}.");
            Console.WriteLine($"The first name of the person with the longest last name: {personList.Where(x => x.LastName.Length == personList.Select(y => y.LastName.Length).Max()).Select(x => x.FirstName).Single()}.");
            Console.WriteLine($"The gender of the oldest person: {personList.Where(x => x.DateOfBirth == personList.Select(y => y.DateOfBirth).Min()).Select(x => x.Gender).Single()}.");

        }
        static List<Person> SeedPersonList()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Sue",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1983, 6, 18),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Tommy",
                    LastName = "Lee",
                    DateOfBirth = new DateTime(1962, 10, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 2, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Barney",
                    LastName = "The Dinosaur",
                    DateOfBirth = new DateTime(1992, 4, 06),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Jane",
                    LastName = "Barber",
                    DateOfBirth = new DateTime(1997, 1, 1),
                    Gender = Person.GenderValue.Female
                },
                new Person()
                {
                    FirstName = "Avery",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 7, 8),
                    Gender = Person.GenderValue.NotStated
                },
                new Person()
                {
                    FirstName = "Emmett",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1985, 6, 3),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 02, 12),
                    Gender = Person.GenderValue.Male
                },
                new Person()
                {
                    FirstName = "Hermione",
                    LastName = "Granger",
                    DateOfBirth = new DateTime(2001, 11, 16),
                    Gender = Person.GenderValue.Female
                }
            };
        }
    }
}