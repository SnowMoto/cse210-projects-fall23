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

        while ( menu != 9)
        {
            Console.WriteLine("Welcome to Kids Chore App");
            Console.WriteLine();
            Console.WriteLine("Keep track of chores and the rewards they earn.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Toddler: Age 2-4");
            Console.WriteLine("2. Little Kid: Age 5-7");
            Console.WriteLine("3. Big Kid: Age 8-11");
            Console.WriteLine("4. Teen: Age 12+");
            Console.WriteLine("5. Good Habits Checklist");
            Console.WriteLine("6. Save Chores");
            Console.WriteLine("7. Load Chore");
            Console.WriteLine("8. Record Chores");
            Console.WriteLine("9. Exit");
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
                pm.SaveChore();   
            }
          
            else if (menu == 7)
            {
                pm.LoadChore();
            }
            else if (menu == 8)
            {
                pm.RecordChore();
            }
            
            else if (menu == 9)
            {
                Console.Write("See you next time ♥");
            }
        }
    }   
}