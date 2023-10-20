using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int chapterNumber = 0;
        int startNumber = 0;
        int endNumber = 0;
        string quit = "";
    
            Console.Write("Enter the book: ");
            string userBook = Console.ReadLine();

            Console.Write("Enter the chapter of the book: ");
            string userChapter = Console.ReadLine();
            chapterNumber = int.Parse(userChapter);

            Console.Write("Enter the first verse of the chapter: ");
            string userVerseS = Console.ReadLine();
            startNumber = int.Parse(userVerseS);

            Console.Write("Enter the last verse of the chapter: (Enter 0 if there isn't) ");
            string userVerseE = Console.ReadLine().ToLower();
            endNumber = int.Parse(userVerseE);

            Console.Write("Enter your scripture: ");
            string userScripture = Console.ReadLine();

            Reference ref1 = new Reference(userBook, userChapter, userVerseS, userVerseE);
            
            Scripture passage = new Scripture(ref1,userScripture);

    while (quit != "q"){

            Console.Clear();
            passage.GetRenderedText();

            Console.WriteLine();
            Console.WriteLine();
            
            Console.Write("If you wish to quite enter q: ");
            quit = Console.ReadLine();
        }
    }
}