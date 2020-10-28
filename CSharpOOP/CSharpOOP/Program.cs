using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            // In-class practice.
            List<int> theList = new List<int>() { 2, 5, 12, 7, 32, 95, 42, 65, 9, 42, 7, 42 };

           Console.WriteLine($"The average of all the items which are less than 20 is: {theList.Where(x => x < 20).Average()}");
           Console.WriteLine($"The largest item that is less than 50 is: {theList.Where(x => x < 50).Max()}");
           Console.WriteLine($"The third distinct item, in numerical order is: {theList.Distinct().OrderBy(x=>x).ToArray()[2]}");
           Console.WriteLine($"The most number of duplicated items is: {theList.Select(x => theList.Where(y => y == x).Count()).Max()}");
           Console.WriteLine($"The sum of all odd numbers is: {theList.Where(x => x % 2 == 1).Sum()}");
           Console.WriteLine($"The lowest number that is divisible by 4 is: {theList.Where(x => x % 4 == 0).Min()}");
           Console.WriteLine($"The average remainder when the distinct items are divided by 5 is: {theList.Distinct().Select(x => x % 5).Average()}");
        }

        }
    }
/*
         static void LINQ()
        {
            // ----------
            // LINQ
            // ----------

            // Initializer lists allow you to pre-populate lists when they are initialized.
            List<string> myList = new List<string>() { "Hello", "World", "Here", "Are", "Some", "Strings", "Hello", "Hello", "World", "True", "False" };

            // Filtering (WHERE)
            myList.Where(x => x.Length > 4);
            // "Hello", "World", "Strings", "Hello", "Hello", "World", "False"

            // Get Associated Values (SELECT)
            myList.Select(x => x.Length);
            // 5, 5, 4, 3, 4, 6, 5, 5, 5, 4, 5

            // Combine the Two
            myList.Where(x => x.Length > 4).Select(x => x.Length);
            // 5, 5, 6, 5, 5, 5, 5

            List<int> myInts = new List<int>() { 6, 3, 10, 42, 5, 12, 37, 95, 1, 50, 100 };

            // Aggregates - Sum, Average, Max, Min
            Console.WriteLine(myInts.Sum());
            Console.WriteLine(myInts.Average());
            Console.WriteLine(myInts.Max());
            Console.WriteLine(myInts.Min());
            // Keep in mind when stringing LINQ methods together, the Aggregate should be after any filtering and selection, as it will collapse the list into a single value.

            // Distinct - Removes all duplicates.
            myInts.Distinct();

            // Converting from a list of one item to a single item.
            myInts.Where(x => x == 12).Single();
            // 12

            // This will throw an exception if there is nothing in the list, OR if there are multiple items in the list.
            // If you don't want that exception thrown, you can use SingleOrDefault, which will return the default for that type if it meets either of the previous failure states.
            myInts.Where(x => x == 11).SingleOrDefault();
            // 0

            // If you don't want the multiple items failure state, you can use First, FirstOrDefault, Last or LastOrDefault, which will still fail if there are no items, but will not fail if there are multiple.
            myInts.Where(x => x > 50).First();
            // 95
            myInts.Where(x => x == 12).First();
            // 12
            myInts.Where(x => x == 11).FirstOrDefault();
            // 0

            // OrderBy is sort of like Sort, except it works with DbSets (to be discussed later).
            myInts.OrderBy(x => x);
/*
            List<Person> myObjectList = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Joe",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Person()
                {
                    FirstName = "Sally",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1988, 2, 2)
                },
                new Person()
                {
                    FirstName = "Bob",
                    LastName = "Jones",
                    DateOfBirth = new DateTime(1992, 3, 3)
                }
            };
*/
//   myObjectList.Where(x => x.LastName[0] == 'S');
// First character of last name is S.
// Joe, Sally

//  myObjectList.Select(x => x.DateOfBirth.Year);
// 1990, 1988, 1992

//  myObjectList.OrderBy(x => x.FirstName);
// Bob, Joe, Sally

//   myObjectList.Select(x => x.DateOfBirth.Year).Average();
// 1990
