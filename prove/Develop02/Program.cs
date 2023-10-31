using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        int number = 0;    

        Journal newJournal = new Journal();

        while (number !=6)
        {
            Console.WriteLine("Welcome to your Journal or Todo Menu: ");
            Console.WriteLine();
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Todo List:");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");
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
                System.Console.WriteLine("> ");
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
                Notes todo = new Notes();

                // Get entry text from user.
                System.Console.Write("Title: ");
                string noteTitle = Console.ReadLine();

                System.Console.Write("> ");
                string noteEntry = Console.ReadLine();
                
                todo._title = noteTitle;
                todo._noteText = noteEntry;

                // Get date.
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Console.WriteLine($"{dateText}");
                todo._date = dateText;
            
                newJournal.AddNotes(todo);
            
            }

            else if(number == 3)
            {
                newJournal.DisplayAll();
            }
            else if(number == 4)
            {
                Console.WriteLine("Name your file: ");
                string fileName = Console.ReadLine();
                newJournal.SaveFile(fileName);
            }

            else if(number == 5)
            {
                Console.WriteLine("Enter file name: ");
                string saveFile = Console.ReadLine();
                newJournal.LoadFile(saveFile);
            }

            else if(number == 6)
            {
                Console.Write("Have a good day!");
            }
        }
    }
}