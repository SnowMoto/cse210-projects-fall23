using System;
using System.Runtime.CompilerServices;

public class BigKid : Chores
{
    private string _ageGroup = "Big Kid";
    private List<int> _screenTime;//random screen time
    private List<int> _moneyEarned;//parent enter money amount for each chore.
    public BigKid(string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete) : base(ageGroup, rewardsEarned, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }
    public BigKid() :base("Big Kid", "", "", false)
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