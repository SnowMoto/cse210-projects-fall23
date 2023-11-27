using System;

public class DailyGoal : Goal
{
    private string _type = "Daily Goal:";
   
    public DailyGoal(string goalType, string name, string description, int points, bool status) : base(goalType, name, description, points, status)
    {

    }
    public override void ListGoal(int i)
    {
        if (GetStatus() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (GetStatus() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {GetStatus}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
       if (GetStatus() == true)
       {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points ♥");
       }
    }
}