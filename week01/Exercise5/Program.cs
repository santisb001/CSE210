using System;
using System.Collections.Generic;

class Program
{
    
    
        static void DisplayWelcome()
        {
            Console.Write("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number: ");
            string response = Console.ReadLine();
            int favNum = int.Parse(response);

            return favNum;
        }

        static int SquareNumber(int wholeNumber)
        { 
            int sqrdNumber = wholeNumber * wholeNumber;

            return sqrdNumber;
        }

        static void DisplayResult(string nameOfUser, int squared)
        {
            Console.WriteLine($"{nameOfUser}, the square of your number is {squared}");

        }


    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int usernum = PromptUserNumber();
        int sqrd = SquareNumber(usernum);
        DisplayResult(userName,sqrd);

    }

}

