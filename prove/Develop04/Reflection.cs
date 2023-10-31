using System;

public class Reflection
{
    public List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public List<string> _question = new List<string>{
        "Why was this experience meaningful to you?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string GetRandomPrompt()
    {
       Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_prompts.Count());
        return _prompts[index];    

    }

    public string GetRandomQuestion()
    {
        Random randomGeneratorTwo = new Random();
        int indexTwo = randomGeneratorTwo.Next(1,_question.Count());
        return _question[indexTwo];    
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"{_prompts}");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"{_question}");
    }
}