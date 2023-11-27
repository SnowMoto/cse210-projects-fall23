public abstract class Chores
{
    private string _ageGroup;
    private string _rewardsEarned;
    private string _choreName;

public Chores (string ageGroup, string rewardsEarned, string choreName)
{
    _ageGroup = ageGroup;
    _rewardsEarned = rewardsEarned;
    _choreName = choreName;
}

public string GetName()
{
    return _ageGroup;
}
public string GetRewards()
{
    return _rewardsEarned;
}
public string GetChoreName()
{
    return _choreName;
}
    public abstract void ParentChoreList(int i);
    public abstract void DisplayProgress(List<Chores> chores);
    public abstract string SaveChore();
    public abstract string LoadChore();
}