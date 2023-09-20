using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userinput = -1;

        while (userinput != 0)
        {
        Console.Write("Enter a list of numbers, type 0 to finish. ");

        string userNumber = Console.ReadLine();
        userinput = int.Parse(userNumber);

        if (userinput != 0)
        {
            numbers.Add(userinput);
        }

        }

       //Find sum of userinput
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

       //Find the user avg number 
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

      //Find user max number
        int max = numbers [0];
         foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}