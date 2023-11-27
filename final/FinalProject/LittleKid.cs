using System;

public class LittleKid : Chores
{
    private string _ageGroup = "Little Kid";
    private string _treatList;
    private int _screenTime;
    private bool _choreIsComplete;
    private List<string>_choreList;
    public LittleKid(string ageGroup, string rewardsEarned, string choreName) : base(ageGroup, rewardsEarned, choreName)
    {
        _choreIsComplete = false;
    }
    public LittleKid(string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete) : base(ageGroup, rewardsEarned, choreName)
    {
        _choreIsComplete = choreIsComplete;
    }
    public Boolean Finished()
    {
        return _choreIsComplete;
    }
    public override void ParentChoreList(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetName()} ({GetChoreName()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetName()} ({GetChoreName()})");
        }
    }
    public override string SaveChore()
    {
        return ($"{_ageGroup}; {GetName()}; {GetChoreName()}; {GetRewards()}; {_choreIsComplete}");
    }
    public override string LoadChore()
    {
        return ($"{_ageGroup}; {GetName()}; {GetChoreName()}; {GetRewards()}; {_choreIsComplete}");
    }
    public override void DisplayProgress(List<Chores> choress)
    {
       _choreIsComplete = true;
       Console.WriteLine($"Congratulations! You have earned {GetRewards()} points ♥");
    }

}