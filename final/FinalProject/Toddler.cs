using System;

public class Toddler : Chores
{
    private string _ageGroup = "Toddler";
    private List<string> _treatList;
    private bool _choreIsComplete;
    private List<string>_choreList;
    public Toddler(string ageGroup, string rewardsEarned, string choreName) : base(ageGroup, rewardsEarned, choreName)
    {
        _choreIsComplete = false;
    }
    public Toddler(string ageGroup, string rewardsEarned, string choreName, bool choreIsComplete) : base(ageGroup, rewardsEarned, choreName)
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

    public void AssignedChores()
    {

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
       Console.WriteLine($"Congratulations! You have earned {GetRewards()} ♥");
    }

}