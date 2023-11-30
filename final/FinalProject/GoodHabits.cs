using System.Runtime.CompilerServices;

public class GoodHabits
{
    private bool _habitComplete;
    public GoodHabits()
    {
        _habitComplete = false;
    }
    public bool GetHabit()
    {
        return _habitComplete;
    }
    public List<string> _goodMorning = new List<string>
    {
        "Make my bed",
        "Brush my teeth",
        "Get dressed for the day",
        "Eat breakfast",
        "Get lunch and backpack ready"
    };

    public List<string> _bedtime = new List<string>
    {
        "Complete Homework and place in backpack",
        "Clean bedroom",
        "Help tidy up the house",
        "Take a shower",
        "Get dressed for bed",
        "Brush teeth",
        "Layout school clothes"
    };
    public void GetAssignedChores()
    {
        Console.WriteLine("Good Morning Chores:");
        foreach (string item in _goodMorning)
        {
            if (GetHabit() == false)
            {
                Console.WriteLine($"[ ] {item}");
            }
            else if (GetHabit() == true)
            {
                Console.WriteLine($"[X] {item}");
            }
        }

        Console.WriteLine("Bedtime Chores:");
        foreach (string item in _bedtime)
        {
            if (GetHabit() == false)
            {
                Console.WriteLine($"[ ] {item}");
            }
            else if (GetHabit() == true)
            {
                Console.WriteLine($"[X] {item}");
            }
        }
    }
}