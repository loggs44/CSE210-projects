using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetFractionString());
        // Console.WriteLine(f1.GetDecimalValue());

        // Fraction f2 = new Fraction(5);
        // Console.WriteLine(f2.GetFractionString());
        // Console.WriteLine(f2.GetDecimalValue());

        // Fraction f3 = new Fraction(3, 4);
        // Console.WriteLine(f3.GetFractionString());
        // Console.WriteLine(f3.GetDecimalValue());

        // Fraction f4 = new Fraction(1, 3);
        // Console.WriteLine(f4.GetFractionString());
        // Console.WriteLine(f4.GetDecimalValue());

        Console.Write("Please enter the top number of the fraction: ");
        int topNumber = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bottom number of the fraction: ");
        int bottomNumber = int.Parse(Console.ReadLine());
        Fraction userFraction = new Fraction(topNumber, bottomNumber);
        Console.WriteLine(string.Format("Here is your fraction: {0} Here is your fraction as a decimal: {1}", userFraction.GetFractionString(), userFraction.GetDecimalValue()));
    }
}