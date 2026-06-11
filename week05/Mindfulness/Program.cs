using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. I implemented an "Activity Log" that keeps track of how many times 
 * the user performs each specific activity during the session. It displays 
 * this summary when they choose to quit.
 * 2. In the ReflectingActivity, I added logic to track which questions have 
 * been asked. It guarantees that a random question is never repeated until 
 * every single question in the list has been asked at least once.
 */

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
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
            Console.Write("Select a choice from the menu: ");
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                listingCount++;
            }
        }

        // Exceeding Requirements output
        Console.Clear();
        Console.WriteLine("Thank you for using the Mindfulness Program!");
        Console.WriteLine("\nSession Summary:");
        Console.WriteLine($"- Breathing Activities Completed: {breathingCount}");
        Console.WriteLine($"- Reflecting Activities Completed: {reflectingCount}");
        Console.WriteLine($"- Listing Activities Completed: {listingCount}");
        Console.WriteLine("\nHave a wonderful, peaceful day.");
    }
}