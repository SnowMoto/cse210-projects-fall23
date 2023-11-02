using System;

public class BreathingActivity : Activity{
    private int _breathIn;
    private int _breatheOut;

    public BreathingActivity(int _duration, string _description, string _activityName, int _pauseStart, int _pauseEnd, string _endingMessage, int breathIn, int breathOut) : base(_duration, _description, _activityName, _pauseStart, _pauseEnd, _endingMessage)
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
            Console.WriteLine("Breath in...");
            Countdown(_breathIn);
            Console.WriteLine("Breath out...");
            Countdown(_breatheOut);

        }
        DisplayEndingMessage(_activityName);

    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
