using System;
public class CheckList : Goal
{
    private int _countTimes;
    private int _count;
    private int _bonusPoints;

    public CheckList(string name, string description, int points, bool isCompelte, int count, int countTimes, int bonusPoints) : base(name, description, points, isCompelte)
    {    
        _countTimes = countTimes;
        _count = count;
        _bonusPoints = bonusPoints;
    
    }
    public bool IsComplete()
    {
        return true;
    }

    public void NumberTimes()
    {
        _count = _count + 1;
    }

    public int GetCountTimes()
    {
        return _countTimes;
    }
    public int GetBonus()
    {
        return _bonusPoints;
    }


    public override void GoalDone(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName} -- Have complete: {NumberTimes}/{_countTimes}");
        }
        else
        {
            Console.WriteLine($"{i}. [X] {GetName} -- Completed: {NumberTimes}/{_countTimes}");
        }
    }    

    public override string SaveGoal()
    {
        return ($"{GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete}; {GetCountTimes()}; {GetBonus()}; {NumberTimes}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {GetIsComplete}; {GetCountTimes()}; {GetBonus()}; {NumberTimes}");
    }
    public override void RecordEvent(List<Goal> goals)
    {

    }
}
