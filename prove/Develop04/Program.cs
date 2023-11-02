using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        while (true)
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

            int menu = int.Parse(Console.ReadLine());   

            if (menu ==1)
            {
                BreathingActivity breathingActivity = new BreathingActivity(10,"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing", 4, 4, "Great job! You have completed the breathing activity.", 5, 5);
                breathingActivity.StartBreathingActivity();            }   

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
                //Listing listingActivity = new Listing(10, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing", 3,3, "Great job! You have completed the listing activity.");
                //Listing.StartListingActivity();   

            }

            else if (menu == 4)
            {
                Console.Write("See you next time!");
            }
          
        }
    }
}