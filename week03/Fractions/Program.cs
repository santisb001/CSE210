using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Frac = new Fraction();
        Frac.SetTop(3);
        Frac.SetBottom(4);
        int Topp = Frac.GetTop();
        int Bottomm = Frac.GetBottom();
        string fracString = Frac.GetFractionString();
        double fracDecimal = Frac.GetDecimalValue();
        Console.WriteLine($"Numerator: {Topp}");
        Console.WriteLine($"Denomionator: {Bottomm}");

        Console.WriteLine($"Fraction: {fracString}");
        Console.WriteLine($"Decimal value: {fracDecimal}");

        Fraction Frac2 = new Fraction(1);
        string fracString2 = Frac2.GetFractionString();
        double fracDecimal2 = Frac2.GetDecimalValue();
        Console.WriteLine($"Fraction: {fracString2}");
        Console.WriteLine($"Decimal value: {fracDecimal2}");

        Fraction Frac3 = new Fraction(5);
        string fracString3 = Frac3.GetFractionString();
        double fracDecimal3 = Frac3.GetDecimalValue();
        Console.WriteLine($"Fraction: {fracString3}");
        Console.WriteLine($"Decimal value: {fracDecimal3}");

        Fraction Frac4 = new Fraction(3,4);
        string fracString4 = Frac4.GetFractionString();
        double fracDecimal4 = Frac4.GetDecimalValue();
        Console.WriteLine($"Fraction: {fracString4}");
        Console.WriteLine($"Decimal value: {fracDecimal4}");

        Fraction Frac5 = new Fraction(1,3);
        string fracString5 = Frac5.GetFractionString();
        double fracDecimal5 = Frac5.GetDecimalValue();
        Console.WriteLine($"Fraction: {fracString5}");
        Console.WriteLine($"Decimal value: {fracDecimal5}");
    }
}