using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is C#");

        Console.Write("What is your favourite colour? ");
        string colour = Console.ReadLine();
        Console.WriteLine($"Your facourite colour is {colour}");

        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}