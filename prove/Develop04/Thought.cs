using System;

public class Thought
{
    public List<string> _positiveThought = new List<string>
    {
        "Never give up on anyone, including yourself as you have come so far."
        ,"You have one life. Choose to be free and let go of the trouble behind."
        ,"Joy can be found in all the small things. Start with you!."
        ,"Be strong and smile at trouble, for it has no power over you."
    };

public string PositiveThought()
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_positiveThought.Count());
        return _positiveThought[index];    
    }
}