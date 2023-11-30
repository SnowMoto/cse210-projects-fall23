public abstract class Chores
{
    private string _ageGroup;
    private string _rewardsEarned;
    private string _choreName;
    private bool _choreIsComplete;

    public Chores (string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete)
    {
        _ageGroup = ageGroup;
        _rewardsEarned = rewardsEarned;
        _choreName = choreName;
        _choreIsComplete = choreIsComplete;
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
    public bool GetChoreIsComplete()
    {
        return _choreIsComplete;
    }
    public abstract void ParentChoreList(int i);
    public abstract void DisplayProgress(List<Chores> chores);
    public abstract string SaveChore();
}