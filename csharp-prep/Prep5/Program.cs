using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        lcWelcomeMessage();

        string lcUserName = PromptUserName();
        int lcUserNumber = PromptUserNumber();

        int lcSquaredNum = SquaredNumber(lcUserNumber);

        DisplayResult(lcUserName, lcSquaredNum);
    }

    static void lcWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string lcUserName = Console.ReadLine();

        return lcUserName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int lcUserNumber = int.Parse(Console.ReadLine());

        return lcUserNumber;
    }

    static int SquaredNumber(int lcNum)
    {
        int lcSquare = lcNum * lcNum;

        return lcSquare;
    }

    static void DisplayResult(string lcName, int lcSquare)
    {
        Console.WriteLine($"{lcName}, the square of your number is {lcSquare}");
    }
}