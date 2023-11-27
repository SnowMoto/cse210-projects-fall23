using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

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
            Console.WriteLine("5. Bonus Good Habits Checklist");
            Console.WriteLine("6. Save Chores");
            Console.WriteLine("7. Load Chores");
            Console.WriteLine("8. Rewards Earned");
            Console.WriteLine();
            Console.WriteLine("Exit");
            Console.WriteLine("Menu option");

            string user = Console.ReadLine(); 
            menu = int.Parse(user);  

            if (menu == 1)
            {
                
            }    
            else if (menu == 2)
            {
                
            }    


            else if (menu == 3)
            {
                
            }

            else if (menu == 4)
            {
                
            }

            else if (menu == 5)
            {
                        
            }

            else if (menu == 6)
            {
                              
            }

            else if (menu == 7)
            {
                
            }
          
            else if (menu == 8)
            {

            }
            
            else if (menu == 9)
            {
                Console.Write("See you next time ♥");
            }
        }
    }   
}