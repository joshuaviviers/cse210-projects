using System;

class Program
{
    static void Main(string[] args)
    {
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1,11);

        Console.Write("What is your magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        int responseNum = 0;

        while (responseNum != magicNumber)
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            responseNum = int.Parse(response);

            if (responseNum > magicNumber)
            {
                Console.WriteLine("Greater than the magic number");
            }
            else if (responseNum < magicNumber)
            {
                Console.WriteLine("Less than the magic number");
            }
        }
         Console.WriteLine("That is correct");
        
    }
}