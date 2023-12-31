using System;
using System.IO;

public class Record

{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    public Record()
    {
        _totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }
    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }
    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            foreach (Goal goal in _goals)
            {
                string goalText = "";
                goalText += goal.GetGoalType();
                goalText += ", ";
                goalText += goal.GetName();
                goalText += ", ";
                goalText += goal.GetDescription();
                goalText += ", ";
                goalText += goal.GetPoints();
                goalText += ", ";
                goalText += goal.GetStatus();
                goalText += ", ";
                outputFile.WriteLine($"{goalText}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            AddPoints(totalPoints);
            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] entries = line.Split(", ");

                string goalType = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);
                if (status == true)
                {
                    totalPoints += points;
                }

                if (entries[0] == "Daily Goal:")
                {
                    DailyGoal dGoal = new DailyGoal(goalType, name, description, points, status);
                    AddGoal(dGoal);
                }
                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(goalType, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(goalType, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(goalType, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
            }
               Console.Write($"\n*** You currently have {totalPoints} points ♥ ***\n");
        }
    }
}