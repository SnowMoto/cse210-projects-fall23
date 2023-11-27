using System;

public class ChecklistGoal : Goal
{
    private string _type = "Check List Goal:";
    private int _numberTimes;
    private int _bonusPoints;
    private int _count;
    public ChecklistGoal(string goalType, string name, string description, int points, int numberTimes, int bonusPoints, bool status) : base(goalType, name, description, points, status)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string goalType, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(goalType, name, description, points, status)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public int GetTimes()
    {
        return _numberTimes;
    }
    public void SetTimes()
    {
        _count = _count + 1;
    }
     public int GetCount()
    {
        return _count;
    }
     public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override void ListGoal(int i)
    {
        if (GetStatus() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (GetStatus() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_count == _numberTimes)
        {
            points = points + _bonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points ♥");
        }
        else if (GetStatus() == true)
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points ♥");
        }
    }

}