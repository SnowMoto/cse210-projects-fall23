using System;
using System.Globalization;

public class Listing : Activity
{
    private List<string> _random_question = new List<string>();
    public List<string> _userList = new List<string>();

 public Listing(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)    
    {
        _random_question.Add("Who are people that you appreciate?");
        _random_question.Add("What are personal strengths of yours?");
        _random_question.Add("Who are people that you have helped this week?");
        _random_question.Add("When have you felt the Holy Ghost this month?");
        _random_question.Add("Who are some of your personal heroes?");
    }

    public void GetRandomList()
    {
       StartActivity(_activityName, _description);
       Console.Clear();
       StartPause(); 
       Random randomGenerator = new Random();
       int index = randomGenerator.Next(1,_random_question.Count);
       Console.WriteLine(_random_question[index]); 
       StartPause();
       Console.WriteLine("Begin in:");
       DateTime startTime = DateTime.Now;
       DateTime endTime = startTime.AddSeconds(_duration);

        _userList.Add(Console.ReadLine());

       while (startTime < endTime)
       {
        int listLength = _userList.Count;
        Console.WriteLine($"Number of listed items: {listLength}");
        Console.WriteLine();
        DisplayEndingMessage(_activityName);
       }
    }
}
