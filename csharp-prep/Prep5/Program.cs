using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program");
        Console.Write("Please enter your name: ");
        string nameinput = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string favnumber = Console.ReadLine();
        int number = int.Parse(favnumber);

        int square = number * number;

        Console.WriteLine($"{nameinput}, the square of your number is {square} ");
    }
}
