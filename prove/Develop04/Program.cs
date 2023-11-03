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
            Console.WriteLine("4. Candle Flame");
            Console.WriteLine();
            Console.WriteLine("5. Exit");
            Console.WriteLine("Menu option");

            int menu = int.Parse(Console.ReadLine());   

            if (menu ==1)
            {
                Breathing breathingActivity = new Breathing(15,"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing", 5, 5, "Great job! You have completed the breathing activity.", 5, 5);
                breathingActivity.StartBreathingActivity();            }   

            else if (menu == 2)
            {
                Reflection Reflect = new Reflection(15,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Reflection", 5,5, "You have completed the Reflection Activity" );
                Reflect.StartReflectionActivity();
            }

            else if (menu == 3)
            {
                Listing listingActivity = new Listing(15, "This activity will help you remember the good things in your life by having you list as many things as you can.", "Listing", 5,5, "Great job! You have completed the listing activity.");
                listingActivity.GetRandomList();   

            }

            else if (menu == 4)
            {
                Candle candleActivity = new Candle (30,"This activity will help you relax your mind and quiet your thoughts. Grab your candle and ignite the flame. Clear your mind and focus on the candle flame.", "Candle Flame", 10, 10, "Great job! You have completed the candle activity.", 10, 10);
                candleActivity.StartCandleActivity();     
            }
          
            else if (menu == 5)
            {
                Console.Write("See you next time!");
            }

        }
    }
}