using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------
            // LINQ
            // ----------
            // Create an empty list
            List<string> myList = new List<string>() { "Hello", "World", "Here", "Are", "Some", "Strings", "Hello", "Hello", "World", "True", "False"};

            // Filtering (WHERE)
            myList.Where(x => x.Length > 4);
            // "Hello", "World", "Strings", "Hello", "Hello", "World", "False"

            // Get Associated Values (SELECT)
            myList.Select(x => x.Length);
            // 5, 5, 4, 3, 2, 6, 5, 5, 5, 4, 5

            // Combine the Two
            myList.Where(x => x.Length > 4).Select(x => x.Length);
            // "Hello", "World", "Strings", "Hello", "Hello", "World", "False"
            // 5, 5, 6, 5, 5, 5, 5

            // Aggregates
            List<int> myInts = new List<int>() { 6, 3, 10, 42, 5, 12, 37, 95, 1, 50, 100 };

            // Aggregates - Sum, Average, Max, Min
            Console.WriteLine(myInts.Sum());
            Console.WriteLine(myInts.Average());
            Console.WriteLine(myInts.Max());
            Console.WriteLine(myInts.Min());

            // Keep in mind when stringing LINQ methods together, the Aggregate should be after any filtering and selection, as it will collapse the list into a single value. 

            // Converting from a list of one item to a single item (Happens when you have a list of one item after filtering and selecting stuff)
            myInts.Where(x => x == 12);
            // Returns [12] (list format)
            myInts.Where(x => x == 12).Single();
            // Returns 12 (int format)
            // NOTE - Single will throw an exception if there is nothing in the list OR if there are multiple items in the list.
            // If you don't want that exception thrown, you can use SingleOrDefault(), which will return the default for that type if it meets either of the previous failure states.
            myInts.Where(x => x == 11).SingleOrDefault();
            // 0

            // IF you don't want the multiple items failure state, you can use First, FirstOrDefault, Last, or LastOrDefault, which will still fail if there are not items, but will not fail if there are multiple items. 

            myInts.Where(x => x > 50).First();
            // 95
            myInts.Where(x => x == 12).First();
            // 12
            myInts.Where(x => x == 11).FirstOrDefault();
            // 0

            // Order By is sort of like a Sort method except it works with DbSets (to be disucussed later)
            myInts.OrderBy(x => x); 

        }
    }
}
