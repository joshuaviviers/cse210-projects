using System;
using System.Linq.Expressions;


// I am struggling to get this to work. Please let me know how i can get it right. My loading wont work

class Program
{
    static void Main(string[] args)
    
    {
        Entry entry = new Entry();
        Journal journal = new Journal();
        string userChoice = "1";

        while (userChoice != "5")
            {
            Console.WriteLine("Welcome to the journal Program! ");
            Console.WriteLine("Please choose one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userChoice = Console.ReadLine();


            switch (userChoice)
            {
                case "1":
                    PrommptGenerator promptGenerator = new PrommptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    
                    //entry

                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;
                    journal._entries.Add(entry);

                    break;
                case "2":
                    
                    foreach(Entry singleEntry in journal._entries)
                    {
                        Console.WriteLine($"{singleEntry._entryDate}");
                        Console.WriteLine($"{singleEntry._prompt}");
                        Console.WriteLine($"{singleEntry._response}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Load");
                    Console.WriteLine("What is the filename?");
                    string _fileName = Console.ReadLine();
                    Console.WriteLine($"{journal.LoadEntry(_fileName)}");

                    break;
                case "4":
                    Console.WriteLine("Save");
                    Console.WriteLine("Enter the name the of file in which you would like to save your jounral entry to");
                    entry._fileName = Console.ReadLine();
                    entry.SaveEntry(entry._fileName, entry._newEntry);
                    journal._saved = 0;
                    break;

                case "5":
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine("Select a valid option");
                    break;
            }
        }
    }
}