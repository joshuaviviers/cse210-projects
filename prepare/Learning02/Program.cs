using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

    if (grade >= 90)
    {
        Console.WriteLine("Your grade is an A. Well done!");
    }
    else if (grade >= 80)
    {
        Console.WriteLine("Your grade is a B. Well done.");
    }
    else if (grade >= 70)
    {
        Console.WriteLine("Your grade is a C.");
    }
    else if (grade >= 60)
    {
        Console.WriteLine("Your grade is a D.");
    }
    else
    {
        Console.WriteLine("Your grade is a F.");
    }

    if (grade >= 70)
    {
        Console.WriteLine("You Passed! Well done");
    }
    else
    {
        Console.WriteLine("Better luck next time");
    }
    }
}