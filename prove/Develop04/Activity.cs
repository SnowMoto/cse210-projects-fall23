using System.IO;

public class Activity{

    private int _activity_name;
    private string _actiivityDescription;
    private int _durationTime;
    private string _endMessage;

    public class Program : Activity{        
        public void DisplayStartMessage()
        {
            while (_activity_name != 0)
            {
                if (_activity_name == 1)
                {
                    Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                }

                else if (_activity_name == 2)
                {
                    Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                }

                else if (_activity_name == 3)
                {
                    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                }
            }
        }
        public void PauseSpinner()
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");   
        }   

        public void PauseTimer()
        {
            Console.WriteLine("When ready hit enter");
            Thread.Sleep(1000);
            Console.WriteLine("Begin");
        }
        public void CountDownTimer()
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(20);
            Thread.Sleep(3000);
            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                Console.WriteLine("Time is up");
            }
        }
    }
}