using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int entryNumber = 0;
        //Create a List
        list<int> numbers = new list<int>();

        while (entryNumber != 0)
        {
            
            //Ask for a number
            Console.WriteLine("Please type a number: ");
            string response = Console.ReadLine();
            entryNumber = int.Parse(response);

            if (entryNumber == 0)
            {
                numbers.Add(entryNumber);
            }
            
        
        
    
        }
        

        //create a loop

        //Add the total of the list

        //Calculate the average



    }
}