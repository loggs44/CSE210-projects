using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string studentPercentGrade = Console.ReadLine();
        int percent = int.Parse(studentPercentGrade);

        string letter = "";
        
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80 && percent <= 90)
        {
            letter = "B";
        }
        else if (percent >= 70 && percent <=80)
        {
            letter = "C";
        }
        else if (percent >= 60 && percent <= 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed the course! Congrats!");
        }
        else
        {
            Console.WriteLine("You did not pass the class... Better luck next time!");
        }
    }
}