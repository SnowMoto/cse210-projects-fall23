public class EternalGoal : Goal
{
    private string _name = "Eternal Goal";
    private bool _check;
    public EternalGoal(string name, string description, int points, bool isCompelte, bool check ) : base(name, description, points, isCompelte)
    {
        _check = check;
    }

    public bool GetCheck()
    {
        return _check;
    }
    public override void GoalDone(int i)
    {
        if (GetIsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
        }
        else if (GetIsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_name}; {GetName()}; {GetDescription()}; {GetPoints()}; {_check}");
    }
    public override string LoadGoal()
    {
        return ($"{_name}; {GetName()}; {GetDescription()}; {GetPoints()}; {_check}");
    }
    public override void RecordEvent(List<Goal> goals)
    {
       _check = true;
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}