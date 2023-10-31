using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

        while (menu != 4)
        {

            Console.WriteLine("Welcome to Mindfulness Activities.");
            Console.WriteLine();
            Console.WriteLine("Select an activity to help unwind from your busy day:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine();
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine();
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine();
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.WriteLine("Menu option");

            string userinput = Console.ReadLine();
            menu = int.Parse(userinput);   

            if (menu ==1)
            {
                Console.WriteLine("Comeback soon");
            }   

            else if (menu == 2)
            {
                Reflection reflection = new Reflection();
                string relfectDay = reflection.GetRandomPrompt();
                Console.WriteLine($"{relfectDay}");

                string askQuestion = reflection.GetRandomQuestion();
                Console.WriteLine($"{askQuestion}");
            }

            else if (menu == 3)
            {
                Listing list = new Listing();
                list.DisplayList();               

            }

            else if (menu == 4)
            {
                Console.Write("See you next time!");
            }
          
        }
    }
}