using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1,100);

        int guess = -1;
        int timesguessed = 0;

        while (guess != magic)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

        if (guess < magic)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magic)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            timesguessed++;
        }
        }
    }
}