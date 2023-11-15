using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

        while ( menu != 5)
        {
            Console.WriteLine("Welcome to the Eternal Quest");
            Console.WriteLine();
            Console.WriteLine("Where you create and can track your goals.");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine();
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine();
            Console.WriteLine("3. Check List of Goals");
            Console.WriteLine();
            Console.WriteLine("4. Recorded Goals");
            Console.WriteLine();
            Console.WriteLine("5. Exit");
            Console.WriteLine("Menu option");

            string user = Console.ReadLine(); 
            menu = int.Parse(user);  

            if (menu ==1)
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
                Console.Write("See you next time!");
            }
        }
    }   
}