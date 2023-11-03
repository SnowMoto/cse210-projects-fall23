using System.IO;

public class Reflection : Activity
{
    public List<string> _prompts = new List<string>();

    public List<string> _question = new List<string>{
        "Why was this experience meaningful to you?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public Reflection(int _duration, string _description, string _activityName, int _pauseStart, int _pauseEnd, string _endingMessage) : base(_duration, _description, _activityName, _pauseStart, _pauseEnd, _endingMessage)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    public void StartReflectionActivity()
    {
        StartActivity(_activityName, _description );
        Console.Clear();
        Console.WriteLine("Get ready to start!");
        Console.WriteLine();
        StartPause();
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
        StartPause();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while  (DateTime.Now < endTime)
        {
            Random randomQuestion = new Random();
            int randomQuestionIndex = randomQuestion.Next(_question.Count);
            Console.WriteLine("> " + _question[randomQuestionIndex]);
            _question.RemoveAt(randomQuestionIndex);
            StartPause(20);
            Console.WriteLine();
        }
            Console.WriteLine("Well Done!");
            StartPause();
            DisplayEndingMessage(_activityName);

    }
}