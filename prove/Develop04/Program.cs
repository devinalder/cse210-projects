using System;
using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.WriteLine($"Completed this session - Breathing: {breathingCount}, Reflection: {reflectionCount}, Listing: {listingCount}");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                reflection.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                listing.Run();
                listingCount++;
            }
        }

        Console.Clear();
        Console.WriteLine($"This session - Breathing: {breathingCount}, Reflection: {reflectionCount}, Listing: {listingCount}");
    }
}