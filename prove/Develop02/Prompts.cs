public class Prompts
{
    public List<string> _prompts = new List<string>
    {
        "Did you remember to start your day with a prayer?",
        "What was the best part of your day?",
        "What is your favortie Prophet quote?",
        "If you could redo one thing from the day, what would it be?",
        "What is your go to song to feel good?"
    };

    public string ToGetRandomGenerator()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_prompts.Count());
        return _prompts[index];    
    }

}