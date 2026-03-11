using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox World of worlds!!!!!!.");
        Console.WriteLine("This is in C#.");

        int number = 5;
        number = 8;
        number += 3;
        number = "blue"; //This is wrong, a variable cannot be changed into a different type.

        //To have a variable with a color I must declarea new variable
        string color = "blue";
        Console.WriteLine(color);

        Console.Write("What color do you like? ");
        string color = Console.Readline();
        Console.WriteLine($"The color you like is {color}");

        if (x < y && x > z)
        {
            Console.WriteLine("x is the greatest");
        }
        else if (y < x && y > z)
        {
            Console.WriteLine("y is the greatest");
        }
        else
        {
            Console.WriteLine("z is the greatest");
        }


    }
}