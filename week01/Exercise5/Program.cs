using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        //Get the user's name and save it in a variable
        string userName = PromptUserName();

        //Get the user's number and save it in a variable
        int userNumber = PromptUserNumber();

        //Pass the number into the squaring function and save the result
        int squaredNumber = SquareNumber(userNumber);

        //Pass both the name and the squared result into the display function
        DisplayResult(userName, squaredNumber);
    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}