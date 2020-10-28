using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list
            List<string> myStringList = new List<string>();

            // Initialize a list to allow you to pre-populate lists when they are initialized
            List<string> myInitializedList = new List<string>() { "Hello", "World", "Here", "Are", "Some", "Strings" };

            // Add things to a list
            myStringList.Add("A String");

            // Remove things from a list by value or reference
            myInitializedList.Remove("Some");

            // Remove things from a list by index/
            myInitializedList.RemoveAt(3);
            // "Hello", "World", "Are", "Some", "Strings"

            // Number of things in a list.
            Console.WriteLine(myInitializedList.Count);
            // 5

            // Add multiple things to a list..
            myInitializedList.AddRange( new string[] {"Test", "Test", "Test", "Yes" } );
            // { "Hello", "World", "Here", "Are", "Some", "Strings", "Test", "Test", "Test", "Yes" }

            // Insert an item at a specific index
            myInitializedList.Insert(5, "True");
            // { "Hello", "World", "Here", "Are", "Some", "True", "Strings", "Test", "Test", "Test", "Yes" }

            // Reverse the Order of a List
            myInitializedList.Reverse();
            // "Yes", "Test", "Test", "Test", "Strings", "True", "Some", "Are", "Here", "World", "Hello"



            // Remove all copies of the same thing from a list.
            myInitializedList.RemoveAll(x => x == "Test");
            // "Yes", "Strings", "True", "Some", "Are", "Here", "World", "Hello"

            // Determine whether something is present in a list
            myInitializedList.Contains("Here");
            // True
            myInitializedList.Contains("Random");
            // False

            // Sort a list alphabetically
            myInitializedList.Sort();
            // "Are", "Hello, "Strings"

            // Remove everything from a list.
            myInitializedList.Clear();



        }
    }
}
