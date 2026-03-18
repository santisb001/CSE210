using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        string wantToPlayAgain = "Yes";

        //Console.Write("Enter the Magic Number: ");
        //string response = Console.ReadLine();
        Random rand = new Random();    
        Console.WriteLine("Welcome to the Guess my Number Game!");
        
        while (wantToPlayAgain == "Yes")
        {
        int MagicNumber = rand.Next(1, 101);
        int guessNumber = 0;
        int tries = 0;

        while (guessNumber != MagicNumber)
            {

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            tries ++;

            if (guessNumber == MagicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of attempts: {tries}");
                }
            else if (guessNumber > MagicNumber)
                {
                    Console.WriteLine("Lower");
                }
            else
                {
                    Console.WriteLine("Higher");
                }
            
            }
        Console.WriteLine("Would you like to play again? ");
        wantToPlayAgain = Console.ReadLine();
        wantToPlayAgain = char.ToUpper(wantToPlayAgain[0]) + wantToPlayAgain.Substring(1).ToLower();
        }
    }
}