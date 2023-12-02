using System;
using System.Runtime.CompilerServices;

public class LittleKid : Chores
{
    private string _ageGroup = "Big Kid";
    public LittleKid(string ageGroup, string choreName, bool choreIsComplete) : base(ageGroup, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }
    public LittleKid() :base("Little Kid", "", false)
    {
        
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