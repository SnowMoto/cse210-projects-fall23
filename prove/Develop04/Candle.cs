using System;
using System.Security.Cryptography.X509Certificates;

public class Candle : Activity{
    private int _candle;
    private int _flame1;
    public List<string> _positiveThought = new List<string>();

    public Candle(int _duration, string _description, string _activityName, int _pauseStart, int _pauseEnd, string _endingMessage) : base(_duration, _description, _activityName, _pauseStart, _pauseEnd, _endingMessage)
    {
        _positiveThought.Add("Never give up on anyone, including yourself as you have come so far.");
        _positiveThought.Add("You have one life. Choose to be free and let go of the trouble behind.");
        _positiveThought.Add("Joy can be found in all the small things. Start with you!.");
        _positiveThought.Add("Be strong and smile at trouble, for it has no power over you.");
    }

    public Candle(int _duration, string _description, string _activityName, int _pauseStart, int _pauseEnd, string _endingMessage, int candle, int flame1) : base(_duration, _description, _activityName, _pauseStart, _pauseEnd, _endingMessage)
    {
        _candle = candle;
        _flame1 = flame1;
    }

    public void StartCandleActivity()
    {
        StartActivity(_activityName, _description);

        int candleCount = _duration / (_candle + _flame1);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        StartPause();
        for (int i = 0; i < candleCount; i++){
            Console.WriteLine("Watch the Flame move side to side...");
            Countdown(_candle);
            Console.WriteLine("Let your mind wander...");
            Countdown(_flame1);
            Console.WriteLine();
        }

        Random random = new Random();
        int randomIndex = random.Next(_positiveThought.Count);
        Console.WriteLine(_positiveThought[randomIndex]);
        Console.WriteLine();
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
