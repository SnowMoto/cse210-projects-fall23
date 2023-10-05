using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        int number = 0;    

        Journal newJournal = new Journal();

        while (number !=5)
        {
            Console.WriteLine("Journal Menu: ");
            Console.WriteLine();
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Menu Option: ");
            string userinput = Console.ReadLine();
            number = int.Parse(userinput);   

            if (number == 1)
            {
                Entry entry = new Entry();

                // Get entry text from user.
                System.Console.WriteLine("");
                string entryText = Console.ReadLine();

                // Place it to the entry text variable.
                entry._entryText = entryText;

                // Get a Prompt. (Hint: Create Prompt first.)
                Prompts prompt = new Prompts();
                prompt.ToGetRandomGenerator();
                
                // Get current date.(Hint: Look at the instructions.)
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{dateText}");

                newJournal.AddEntry(entry);                        

            }

            else if(number == 2)
            {
                newJournal.DisplayAll();
            }

        }

}
}