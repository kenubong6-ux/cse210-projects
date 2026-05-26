using System;

// EXCEEDING REQUIREMENTS: 
// I added a "_mood" attribute to the Entry class. When writing a new entry, 
// the user is prompted to record their current mood, which is then saved to, 
// loaded from, and displayed alongside the journal entry data.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool keepRunning = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (keepRunning)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Console.Write("What is your current mood? ");
                string moodInput = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = moodInput;
                
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? (e.g., myJournal.txt): ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename to save as? (e.g., myJournal.txt): ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please type a number from 1 to 5.");
            }
        }
    }
}