using System;
using System.Globalization;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            string name, location;

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("Where are you from: ");
            location = Console.ReadLine();

            //Step 3
            Console.WriteLine($"\nMy name is {name}, I am from {location}.");

            // Steps 4 & 5
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            DateTime today = DateTime.Now;
            DateTime christmas = new DateTime(today.Year, 12, 25);
            Console.WriteLine($"\nToday's date is {today.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}," +
                $" and there are {(christmas - today).Days} days until Christmas.");

            // Steps 6 & 7
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("\n~ ~ ~ Window Calculator ~ ~ ~");
            Console.Write("Window width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Window height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
            Console.WriteLine();
        }

    }
}
