using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;
        Record goals = new Record();

        while ( menu != 5)
        {
            Console.WriteLine("Welcome to the Eternal Quest");
            Console.WriteLine();
            Console.WriteLine("Where you create and can track your goals.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Daily Goal");
            Console.WriteLine("2. Simple Goals");
            Console.WriteLine("3. Eternal Goals");
            Console.WriteLine("4. Check List of Goals");
            Console.WriteLine("5. Record Goal Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine();
            Console.WriteLine("8. Exit");
            Console.WriteLine("Menu option");

            string user = Console.ReadLine(); 
            menu = int.Parse(user);  

            if (menu == 1)
            {
                Console.Clear();
                Console.WriteLine("What is the name of your goal?  ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?  ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?  ");
                int points = int.Parse(Console.ReadLine());
                DailyGoal dGoal = new DailyGoal("Simple Goal:", name, description, points);
                goals.AddGoal(dGoal);
            }    
            else if (menu == 2)
            {
                Console.Clear();
                Console.WriteLine("What is the name of your goal?  ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?  ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?  ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                goals.AddGoal(sGoal);
            }    


            else if (menu == 3)
            {
                Console.WriteLine("What is the name of your goal?  ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?  ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?  ");
                int points = int.Parse(Console.ReadLine());
                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                goals.AddGoal(eGoal);
            }

            else if (menu == 4)
            {
                Console.WriteLine("What is the name of your goal?  ");
                string name = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?  ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal?  ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                int numberTimes = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times?  ");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                goals.AddGoal(clGoal);
            }

            else if (menu == 5)
            {
                Console.Clear();  
                Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                goals.RecordGoalEvent();               
            }

            else if (menu == 6)
            {
                goals.SaveGoals();                 
            }

            else if (menu == 7)
            {
                Console.Clear();  
                Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                goals.LoadGoals(); 
            }
          
            else if (menu == 8)
            {
                Console.Write("See you next time!");
            }
        }
    }   
}