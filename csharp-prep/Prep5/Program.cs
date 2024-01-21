using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string username = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquaredNumber(number);

        Console.WriteLine($"Brother {username}. Your number is {number} and the square of your number is {squared}");
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;

    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        string favNumber = Console.ReadLine();
        int number = int.Parse(favNumber);

        return number;
    }

    static int SquaredNumber(int number)
    {
        int squared = number * number;

        return squared;
    }

}