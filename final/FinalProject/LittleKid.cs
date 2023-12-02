using System;
using System.Runtime.CompilerServices;

public class LittleKid : Chores
{
    private string _ageGroup = "Big Kid";
    private int _screenTime;//parent enter screen time
    public LittleKid(string ageGroup, string choreName, bool choreIsComplete) : base(ageGroup, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }
    public LittleKid() :base("Little Kid", "", false)
    {
        
    }
     public int GetTime()
    {
        return _screenTime;
    }
    public void AddScreenTime(int time)
    {
        _screenTime += time;
    }
   public List<string> _treats = new List<string>
    {
        "Candy",
        "Ice Cream",
        "Cookie",
        "Snack Choice",
        "Kids Choice"
    };
    public override void RewardsEarned()//implement method for reward.
    {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(1,_treats.Count());
        Console.WriteLine($"\n*** You have {_treats[index]} points! ***\n");

    }
    public override void ParentChoreList(int i)
    {
        if (GetChoreIsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetChoreName()})");
        }
        else if (GetChoreIsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetChoreName()})");
        }
    }
    public override string SaveChore()
    {
        return ($"{_ageGroup};[ {GetChoreIsComplete()} ] {GetChoreName()};");
    }
    public override void DisplayProgress(List<Chores> chores)
    {
        Console.WriteLine($"{_ageGroup};[ {GetChoreIsComplete()} ];");
    }
}