using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int startNumber = 0;
        int endNumber = 0;
        string quit = "";

        /*Console.WriteLine("Welcome to Scripture Memory");

        Console.Write("Enter the book: ");
        string userBook = Console.ReadLine();

        Console.Write("Enter the chapter of the book: ");
        string userChapter = Console.ReadLine();
        int chapterNumber = int.Parse(userChapter);

        Console.Write("Enter the first verse of the chapter: ");
        string userVerseS = Console.ReadLine();
        startNumber = int.Parse(userVerseS);

        Console.Write("Enter the last verse of the chapter: (Enter 0 if there isn't) ");
        string userVerseE = Console.ReadLine().ToLower();
        endNumber = int.Parse(userVerseE);

        Console.Write("Enter your scripture: ");
        string userScripture = Console.ReadLine();*/
        

        string userBook = "John";
        string userChapter = "3";
        string userVerseS = "16";
        string userVerseE = "0";
        string userScripture = "For God so loved the world, that he gave his only begotten son that whoso believeth in him should not perish but have everlasting life.";

        Reference ref1 = new Reference(userBook, userChapter, userVerseS, userVerseE);
        
        Scripture passage = new Scripture(ref1,userScripture);

        while (quit != "q" && !passage.AllHidden()){

                Console.Clear();
                passage.GetRenderedText();

                Console.WriteLine();
                Console.WriteLine();
               
                bool returnValue = passage.HideWords();
                Console.WriteLine($"HideWords returned {returnValue}");
 
                Console.Write("If you wish to quit enter q: ");
                quit = Console.ReadLine();
        }
    }
}