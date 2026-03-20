using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int userAction = 0;
        //Main loop
        while (userAction != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine();
            Cosole.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Entry firstEntry = new Entry();
            firstEntry.Display();
        }
    }
}