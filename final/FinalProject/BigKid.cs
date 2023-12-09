using System;
using System.Runtime.CompilerServices;

public class BigKid : Chores
{
    private string _ageGroup = "Big Kid";

    public BigKid(string ageGroup, string choreName, bool choreIsComplete)
        : base(ageGroup, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }

    public BigKid()
        : base("Big Kid", "", false) { }

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
        return ($"{_ageGroup};[ {GetChoreIsComplete()} ] {GetChoreName()}; ");
    }
}
