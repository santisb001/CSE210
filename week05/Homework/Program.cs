using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment1 = new MathAssignment("2.5","9-17","Roberto Carlos","Fractions");
        WritingAssignment writingAssignment2 = new WritingAssignment("The History of bubbles and its potential uses", "Julius Cesar","Physics Studies");

        string name = mathAssignment1.GetSummary();
        string math = mathAssignment1.GetHomeworkList();
        Console.WriteLine($"{name}");
        Console.WriteLine($"{math}");

        Console.WriteLine();

        string name2 = writingAssignment2.GetSummary();
        string wrt = writingAssignment2.GetWritingInformation();
        Console.WriteLine($"{name2}");
        Console.WriteLine($"{wrt}");
    }
}