using System;

public class EternalGoal : Goal
{
    private string _type = "Eternal Goal:";
    public EternalGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points, status)
    {

    }
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus()}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus()}");
    }
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points ♥");
    }


}