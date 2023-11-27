using System;

public abstract class Goal
{
    private string _type;
    private string _name;
    private string _description;
    private int _points;
    private bool _status;
    public Goal(string goalType, string name, string description, int points, bool status)
    {
        _type = goalType;
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }
    public string GetGoalType()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public abstract void ListGoal(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordGoalEvent(List<Goal> goals);
}