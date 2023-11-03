using System;

public class Candle : Activity{
    private int _candle;
    private int _flame1;

    public Candle(int _duration, string _description, string _activityName, int _pauseStart, int _pauseEnd, string _endingMessage, int candle, int flame1) : base(_duration, _description, _activityName, _pauseStart, _pauseEnd, _endingMessage)
    {
        _candle = candle;
        _flame1 = flame1;
        
    }

    public void StartCandleActivity(){
        StartActivity(_activityName, _description);

        int candleCount = _duration / (_candle + _flame1);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        StartPause();
        for (int i = 0; i < candleCount; i++){
            Console.WriteLine("Watch the Flame...");
            Countdown(_candle);
            Console.WriteLine("Watch it sway side to side...");
            Countdown(_flame1);
            Console.WriteLine("Let your mind wander...");
            Countdown(_flame1);
        }
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
