using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // 1. Loop to get the numbers
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        
        int sum = 0;
        int max = numbers[0]; 
        
        // Initialize with the maximum possible integer value
        int smallestPositive = int.MaxValue; 

        // Loop through every number in the list
        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }

            // STRETCH 1: Check if it is positive AND smaller than our current smallest
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        float average = ((float)sum) / numbers.Count;

        // Print the core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        //Sort the list and print it
        numbers.Sort();
        
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}