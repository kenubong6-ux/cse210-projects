using System;

// EXCEEDING REQUIREMENTS:
// To exceed requirements, I updated the HideRandomWords method in the Scripture class 
// so that it only selects from words that are not already hidden. This prevents the 
// random number generator from wasting cycles picking already-hidden words.

class Program
{
    static void Main(string[] args)
    {
        // Set up the scripture reference and text
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Scripture myScripture = new Scripture(myRef, text);

        string input = "";

        // Loop runs until the user types 'quit' or all words are hidden
        while (input.ToLower() != "quit" && !myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                // Hide 3 words every time the user presses enter
                myScripture.HideRandomWords(3); 
            }
        }

        // Display the fully hidden scripture one last time before exiting
        if (myScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine("\nGreat job, You have successfully memorized the scripture.");
        }
    }
}