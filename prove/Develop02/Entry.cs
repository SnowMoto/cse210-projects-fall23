using System;

public class Entry
    {
       public string message  = "";
       public string prompt = "";
       public string date = DateTime.Now.ToString("dd-MM-yyyy");

       public void Display(){
        Console.WriteLine($"Date: {date} - Prompt: {message}");
        Console.WriteLine(char.ToUpper(prompt[0]) + prompt.Substring(1));
        }
    
    }