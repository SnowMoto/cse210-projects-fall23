using System;
using System.Runtime.CompilerServices;

public class Toddler : Chores
{
    private string _ageGroup = "Toddler";
    public object AddChoreNamwe { get; }

    public Toddler(string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete) : base(ageGroup, rewardsEarned, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }
    public Toddler() :base("Toddler", "", "", false)
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
        return ($"{_ageGroup};[ {GetChoreIsComplete()} ] {GetChoreName()}; {GetRewards()}; ");
    }
    public override void DisplayProgress(List<Chores> chores)
    {
        Console.WriteLine($"{_ageGroup};[ {GetChoreIsComplete()} ]; {GetRewards()};");
    }
}