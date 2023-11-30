using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        ProgressManagement pm = new ProgressManagement();
        GoodHabits habit = new GoodHabits();

        while ( menu != 5)
        {
            Console.WriteLine("Welcome to Kids Chore App");
            Console.WriteLine();
            Console.WriteLine("Here you can track their chores and the rewards they have earned.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Toddler: Age 2-4");
            Console.WriteLine("2. Little Kid: Age 5-7");
            Console.WriteLine("3. Big Kid: Age 8-11");
            Console.WriteLine("4. Teen: Age 12+");
            Console.WriteLine("5. Good Habits Checklist");
            Console.WriteLine("6. Save Chores");
            Console.WriteLine("7. Load Chores");
            Console.WriteLine("8.Exit");
            Console.WriteLine();
            Console.WriteLine("Menu option");

            string user = Console.ReadLine(); 
            menu = int.Parse(user);  

            if (menu > 0 && menu < 4)
            {
                pm.AddChore(menu);
            }    

            else if (menu == 5)
            {
                habit.GetAssignedChores();             
            }

            else if (menu == 6)
            {
                
                
            }
          
            else if (menu == 7)
            {

            }
            
            else if (menu == 8)
            {
                Console.Write("See you next time ♥");
            }
        }
    }   
}