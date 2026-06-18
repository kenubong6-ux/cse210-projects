using System;

// EXCEEDING REQUIREMENTS:
// I added a gamification "Leveling System" to the GoalManager. 
// As the user records events and their score increases, they rank up 
// through different titles (e.g., Novice, Apprentice, Master, Legend). 
// This title is displayed on the main menu, giving the user a greater 
// sense of progression beyond just a raw point total.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}