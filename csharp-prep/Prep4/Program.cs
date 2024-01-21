using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        List<int> numberList = new List<int>();

        while (number != 0)
        {

        Console.WriteLine("Enter number");
        string newNumber = Console.ReadLine();
        number = int.Parse(newNumber);
        
        numberList.Add(number);
        
        }

        Console.WriteLine(numberList.Count());

        if (number == 0)
        {
        foreach (int numbers in numberList)
        {
        Console.WriteLine(numbers);
        }
        }
         int sum = 0;

        foreach (int numbers in numberList)
        {
            sum += numbers;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {Convert.ToDecimal(average) % 10}");

        int max = numberList[0];

        foreach (int numbers in numberList);
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
        
    }
}

// ANSWER:


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<int> numbers = new List<int>();
        
//         // Please note we could use a do-while loop here instead
//         int userNumber = -1;
//         while (userNumber != 0)
//         {
//             Console.Write("Enter a number (0 to quit): ");
            
//             string userResponse = Console.ReadLine();
//             userNumber = int.Parse(userResponse);
            
//             // Only add the number to the list if it is not 0
//             if (userNumber != 0)
//             {
//                 numbers.Add(userNumber);
//             }
//         }

//         // Part 1: Compute the sum
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }

//         Console.WriteLine($"The sum is: {sum}");

//         // Part 2: Compute the average
//         // Notice that we first cast the sum variable to be a float. Otherwise, because
//         // both the sum and the count are integers, the computer will do integer division
//         // and I will not get a decimal value (even though it puts the result into a float variable).

//         // By making one of the variables a float first, the computer knows that it has to
//         // do the floating point division, and we get the decimal value that we expect.
//         float average = ((float)sum) / numbers.Count;
//         Console.WriteLine($"The average is: {average}");

//         // Part 3: Find the max
//         // There are several ways to do this, such as sorting the list
        
//         int max = numbers[0];

//         foreach (int number in numbers)
//         {
//             if (number > max)
//             {
//                 // if this number is greater than the max, we have found the new max!
//                 max = number;
//             }
//         }

//         Console.WriteLine($"The max is: {max}");
//     }
// }