using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;

            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine().Trim();

            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine().Trim();

            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
