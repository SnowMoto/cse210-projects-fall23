using System;
using System.Security.Cryptography.X509Certificates;

public class Candle : Activity{
    private int _candle;
    private int _flame1;
    public Candle(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage, int candle, int flame1) : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)
    {
        _candle = candle;
        _flame1 = flame1;
    }
    public void StartCandleActivity()
    {
        StartActivity(_activityName, _description);

        int candleCount = _duration / (_candle + _flame1);
        Console.Clear();
        Console.WriteLine("Begin watching the flame.");
        StartPause();

        for (int i = 0; i < candleCount; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Watch the Flame move side to side...");
            Countdown(_candle);
            Console.WriteLine("Let your mind wander...");
            Countdown(_flame1);
            Console.WriteLine();
        }

        Thought thought = new Thought();
        string newThought = thought.PositiveThought();
        Console.WriteLine($"{newThought}");
        DisplayEndingMessage(_activityName);
    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "  ♥  ");
            System.Threading.Thread.Sleep(1000);
        }
            Console.WriteLine();
    }
}
