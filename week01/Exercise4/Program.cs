using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        int entryNumber = -1;
        //Create a List
        List<int> numbers = new List<int>();
        int maximum = 0;

        while (entryNumber != 0)
        {
            
            //Ask for a number
            Console.WriteLine("Please type a number: ");
            string response = Console.ReadLine();
            entryNumber = int.Parse(response);

            if (entryNumber == 0)
            {
                Console.WriteLine("Ending count... ");
            }
            else if (entryNumber > maximum)
            {
                numbers.Add(entryNumber);
                maximum = entryNumber;
            }
            else
            {
                numbers.Add(entryNumber);
            }
        
    
        }

        //Add the total of the list
        foreach (int i in numbers)
        {
            total += i;
        }

        //Calculate the average
        double average = 0;
        average = total / numbers.Count;
        

        Console.WriteLine($"Total sum: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Maximum number: {maximum}");

    }
}