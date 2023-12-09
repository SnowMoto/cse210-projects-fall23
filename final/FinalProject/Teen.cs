using System;
using System.Runtime.CompilerServices;

public class Teen : Chores
{
    private string _ageGroup = "Teen";
    private int _screenTime; //parent enter screen time
    private int _moneyEarned; //parent enter money amount for each chore.

    public Teen(string ageGroup, string choreName, bool choreIsComplete)
        : base(ageGroup, choreName, choreIsComplete)
    {
        _ageGroup = ageGroup;
    }

    public Teen()
        : base("Teen", "", false) { }

    public int GetTime()
    {
        return _screenTime;
    }

    public int GetMoney()
    {
        return _moneyEarned;
    }

    public void AddScreenTime(int time)
    {
        _screenTime += time;
    }

    public void AddMoneyEarned(int money)
    {
        _moneyEarned += money;
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
}
