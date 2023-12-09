using System.Runtime.CompilerServices;

public class GoodHabits
{
    private bool _habitComplete;

    public GoodHabits(bool habitComplete)
    {
        _habitComplete = habitComplete;
    }

    public GoodHabits() { }

    public bool GetHabitComplete()
    {
        return _habitComplete;
    }

    public void SetHabitComplete()
    {
        _habitComplete = true;
    }

    public List<string> _goodMorning = new List<string>
    {
        "1. Make my bed",
        "2. Brush my teeth",
        "3. Get dressed for the day",
        "4. Eat breakfast",
        "5. Get lunch and backpack ready"
    };

    public List<string> _bedtime = new List<string>
    {
        "1. Complete Homework and place in backpack",
        "2. Clean bedroom",
        "3. Help tidy up the house as needed",
        "4. Take a shower",
        "5. Get dressed for bed",
        "6. Brush teeth",
        "7. Layout clothes"
    };

    public void AssignedGoodHabit()
    {
        Console.WriteLine("A guided list to help children practice daily Good Habits.");
        Console.WriteLine("\nIf all completed on their own, give a bonus reward found in chores.");
        Console.WriteLine("");
        Console.WriteLine("Good Morning Chores:");
        foreach (string item in _goodMorning)
        {
            Console.WriteLine($"{item}");
        }

        Console.WriteLine();

        Console.WriteLine("Bedtime Chores:");
        foreach (string item in _bedtime)
        {
            Console.WriteLine($"{item}");
        }
    }
}
