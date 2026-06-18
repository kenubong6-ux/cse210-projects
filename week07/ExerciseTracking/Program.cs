using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list to hold the base Activity objects
        List<Activity> activities = new List<Activity>();

        // Instantiate one of each type
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycling = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swimming = new Swimming("05 Nov 2022", 20, 40);

        // Add them to the list
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("Exercise Tracking Summary:\n");

        // Iterate through the list and call GetSummary using polymorphism
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}