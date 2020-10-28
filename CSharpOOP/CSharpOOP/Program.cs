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

            // ----------------
            // Stacks & Queues
            // ----------------

            // A stack of papers or a queue of people
            // Stack: Last in, First Out
            Stack<int> myIntStack = new Stack<int>();

            myIntStack.Pop();

            // Push - Add something to the stack
            myIntStack.Push(12);
            myIntStack.Push(42);
            myIntStack.Push(3);
            // 12, 42, 3

            // Pop - "Grab the Top Thing"
            Console.WriteLine(myIntStack.Pop());
            // 3
            // Note that Pop() REMOVEs the item from the Stack
            // If you just want to get it without removing it, use Peek
            Console.WriteLine(myIntStack.Peek());
            // 42

            // Queues: First In, First Out
            Queue<int> myIntQueue = new Queue<int>();

            // Enqueue = Add
            myIntQueue.Enqueue(8);
            myIntQueue.Enqueue(42);
            myIntQueue.Enqueue(7);

            // Dequeue = Pop() but from the "front" instead of the "top".
            Console.WriteLine(myIntQueue.Dequeue());
            // 8
            
            // Peek - Works the same way in Queues as they do in Stacks, view the next thing without removing it. 
            Console.WriteLine(myIntQueue.Peek());
            // 42


        }
    }
}
