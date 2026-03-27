using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference firstNefiReference = new Reference("1 Nefi",3,7);
        Scripture scripToStudy = new Scripture(firstNefiReference,"I will go and do the things wich the Lord hath commanded.");
        Random randNum = new Random();
       
        int rNum = randNum.Next(0,5);

        while (!scripToStudy.IsCompletelyHidden())
        {
        
        
        string display = scripToStudy.GetDisplay();
        Console.WriteLine($"{display}");
        Console.WriteLine("\nPress Enter or type 'quit': ");
        string input = Console.ReadLine();

        //Check if the user wants to quit
        if (input.ToLower() == "quit")
        {
            break;
        }

        //Show the scripture with the hidden words
        scripToStudy.HideRandomWords(rNum);
        display = scripToStudy.GetDisplay();
        if (scripToStudy.IsCompletelyHidden())
            {
                Console.WriteLine($"{display}");
            }
        Console.WriteLine($"{display}");
        Console.Clear();

        }

    }
}