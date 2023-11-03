using System;

public class Breathing : Activity
{
    private int _breathIn;
    private int _breatheOut;

    public Breathing(int duration, string description, string activityName, int pauseStart, int pauseEnd, string endingMessage, int breathIn, int breathOut) : base(duration, description, activityName, pauseStart, pauseEnd, endingMessage)
    {
        _breatheOut = breathOut;
        _breathIn = breathIn;
    }

    public void StartBreathingActivity(){
        StartActivity(_activityName, _description);

        int breathCount = _duration / (_breathIn + _breatheOut);
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        StartPause();
        for (int i = 0; i < breathCount; i++){
            Console.WriteLine("Breath in ...");
            Countdown(_breathIn);
            Console.WriteLine("Breath out ...");
            Countdown(_breatheOut);
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
