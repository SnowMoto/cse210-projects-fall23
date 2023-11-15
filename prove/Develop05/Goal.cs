using System;
using System.ComponentModel;

public abstract class Goal 
{
    private string _name;
    private string _description;
    private int _points;
    private int _countTimes;
    private int _count;
    private bool _isComplete;

    public Goal (string name, string description, int points, bool isCompelte )
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isCompelte;
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

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public abstract void GoalDone(int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract void RecordEvent(List<Goal> goals);
}