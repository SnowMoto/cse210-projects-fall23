using System;
using System.Runtime.CompilerServices;

public class LittleKid : Chores
{
    private string _ageGroup = "Big Kid";
    private List<string> _treats;//random gen for treats
    private List<int> _screenTime;//random gen for screen time
    public LittleKid(string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete) : base(ageGroup, rewardsEarned, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }
    public LittleKid() :base("Little Kid", "", "", false)
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
        return ($"{_ageGroup}; {GetName()}; {GetChoreName()}; {GetRewards()}; {GetChoreIsComplete()}");
    }
    public override void DisplayProgress(List<Chores> choress)
    {
        Console.WriteLine($"{_ageGroup}; {GetName()}; {GetChoreName()}; {GetRewards()}; {GetChoreIsComplete()}");
    }

}