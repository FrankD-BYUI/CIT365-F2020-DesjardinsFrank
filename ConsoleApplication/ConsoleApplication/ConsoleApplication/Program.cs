using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, location;

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("Where are you from: ");
            location = Console.ReadLine();

            Console.WriteLine($"My name is {name}, I am from {location}.");
            Console.WriteLine($"Todays date is {DateTime.Now.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}" +
                $" and there are {12} days until Christmas.");
        }
    }
}
