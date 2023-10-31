using System;
using System.Globalization;

public class Listing
{
    private List<string> _random_question = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomList()
    {
       Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_random_question.Count);
        return _random_question[index];    
    }

    public void DisplayList()
    {
        string ask = GetRandomList();
        Console.WriteLine($"{ask}");
        string _userList = Console.ReadLine();

        int i = 0;
        while (i != 0){

           Console.WriteLine($"");
        }
    }
}
