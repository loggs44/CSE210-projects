// Logan Clark
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random lcRandGenerator = new Random();
        int lcNumber = lcRandGenerator.Next(1,100);

        int lcUserNum = -1;

        while (lcUserNum != lcNumber)
        {

            Console.Write("What is the magic number? ");
            lcUserNum = int.Parse(Console.ReadLine());
            if (lcUserNum < lcNumber)
            {
                Console.WriteLine("You guessed to low!");
            }
            else if (lcUserNum > lcNumber)
            {
                Console.WriteLine("You guess to high!");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }
        }
    }
}