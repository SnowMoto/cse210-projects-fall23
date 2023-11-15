public class Record
{
    private int _totalPoints;
    private List<Goal> _goalList = new List<Goal>();

    public Record()
    {
        _totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goalList.Add(goal);
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
        return _goalList;
    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }
}