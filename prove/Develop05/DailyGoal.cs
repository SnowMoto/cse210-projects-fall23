using System;

public class DailyGoal : Goal
{
    private string _type = "Daily Goal:";
    private bool _status;
    public DailyGoal(string goalType, string name, string description, int points) : base(goalType, name, description, points)
    {
        _status = false;
    }
    public DailyGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
       _status = true;
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}