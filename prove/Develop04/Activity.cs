using System.IO;

public class Activity {

public int _duration;
public string _description;
public string _activityName;
private int _pauseStart;
private int _pauseEnd;
private string _endingMessage;

    public Activity(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage)
    {
        _duration = duration;
        _description = description;
        _activityName = activityName;
        _pauseStart = pauseStart;
        _pauseEnd = pauseEnd;
        _endingMessage = endingMessage;
    }
    public void DisplayStartingMessage(string activityName,string message)
    {
        _description = message;
        _activityName = activityName;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long in seconds would you like your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayHoldAnimation(int pauseSeconds)
    {
        string[] spinner = {"-","|", "/" };
        for (int i = 0; i < pauseSeconds; i++ ){
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(500);
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
        }
    }

    public void StartPause(int duration = 10)
    {
        DisplayHoldAnimation(duration);

    }

    public void DisplayEndingMessage(string _activityName)
    {
        Console.WriteLine(_endingMessage);
        DisplayHoldAnimation(10);

    }

    public void StartActivity(string _activityName, string _description)
    {
        Console.Clear();
        StartPause();
        DisplayStartingMessage(_activityName, _description);

    }

}