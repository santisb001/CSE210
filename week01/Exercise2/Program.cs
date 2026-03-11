using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type the grade % you received: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        int F = 59;

        if (grade >= A)
        {
            Console.WriteLine("You got an A");
        }
        else if (grade >= B)
        {
            Console.WriteLine("You got a B");
        }
        else if (grade >= C)
        {
            Console.WriteLine("You got a C");
        }
        else if (grade >= D)
        {
            Console.WriteLine("You got a D");
        }
        else
        {
            Console.WriteLine("You got a F");
        }

        if (grade >= C)
        {
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("You have not passed.");
            Console.WriteLine("Don't give up! Try again next time.");
        }

        

    }
}