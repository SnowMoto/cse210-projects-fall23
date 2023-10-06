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
            Console.WriteLine("Welcome to your Journal Menu: ");
            Console.WriteLine();
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Select Menu Option: ");
            string userinput = Console.ReadLine();
            number = int.Parse(userinput);   

            if (number == 1)
            {
                Entry entry = new Entry();

                 // Get a Prompt. (Hint: Create Prompt first.)
                Prompts prompt = new Prompts();
                string newPrompt = prompt.ToGetRandomGenerator();
                Console.WriteLine($"{newPrompt}");
                entry._promptText = newPrompt;

                // Get entry text from user.
                System.Console.WriteLine("");
                string entryText = Console.ReadLine();

                entry._entryText = entryText;

                // Get date.
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{dateText}");
                entry._date = dateText;

                newJournal.AddEntry(entry);                        

            }

            else if(number == 2)
            {
                newJournal.DisplayAll();
            }

        }

}
}