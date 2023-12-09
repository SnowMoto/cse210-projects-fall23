using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        ProgressManagement pm = new ProgressManagement();
        GoodHabits habit = new GoodHabits();

        while (menu != 9)
        {
            Console.WriteLine("Welcome to Chore Tracker for kids!");
            Console.WriteLine();
            Console.WriteLine("Keep track of chores and earned rewards.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Toddler: Age 2-4"); // Assign chores by age groups.
            Console.WriteLine("2. Little Kid: Age 5-7");
            Console.WriteLine("3. Big Kid: Age 8-11");
            Console.WriteLine("4. Teen: Age 12+");
            Console.WriteLine("5. Good Habits List"); //Just a reference list for children to follow and develop skills.
            Console.WriteLine("6. Record Chores"); // Record current chores.
            Console.WriteLine("7. Save Chores"); // Save chores progress.
            Console.WriteLine("8. Update Chores"); //Load and update chores progress.
            Console.WriteLine("9. Exit");
            Console.WriteLine();
            Console.WriteLine("Menu option: ");

            string user = Console.ReadLine();
            menu = int.Parse(user);

            if (menu > 0 && menu <= 4)
            {
                pm.AddChore(menu);
                Console.WriteLine();
            }
            else if (menu == 5)
            {
                habit.AssignedGoodHabit();
                Console.WriteLine();
            }
            else if (menu == 6)
            {
                pm.RecordChore();
                Console.WriteLine();
            }
            else if (menu == 7)
            {
                pm.SaveChore();
                Console.WriteLine();
            }
            else if (menu == 8)
            {
                pm.UpdateChore();
                Console.WriteLine();
            }
            else if (menu == 9)
            {
                Console.Write("See you next time ♥");
            }
        }
    }
}
