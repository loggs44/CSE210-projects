// Logan Clark
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int lcUserNum = -1;
        while (lcUserNum != 0)
        {
            Console.Write("Please enter a series fo numbers: (Enter 0 when done.) ");
            string lcResponse = Console.ReadLine();
            lcUserNum = int.Parse(lcResponse);

            if (lcUserNum != 0)
            {
                numbers.Add(lcUserNum);
            }
        }

        int lcSum = 0;
        foreach (int number in numbers)
        {
            lcSum += number;
        }

        Console.WriteLine($"The sum of all the numbers is: {lcSum}");

        float lcAverage = ((float)lcSum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {lcAverage}");

        int lcMax = numbers[0];
        
        foreach (int number in numbers)
        {
            if (number > lcMax)
            {
                lcMax = number;
            }
        }

        Console.WriteLine($"The max is: {lcMax}");
    }
}