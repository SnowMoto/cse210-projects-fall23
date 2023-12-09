using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ChoreIdeas
{
    private bool _choreDone;

    public ChoreIdeas() { }

    public ChoreIdeas(bool choreDone)
    {
        _choreDone = choreDone;
    }

    public bool GetChoreIsDone()
    {
        return _choreDone;
    }

    public void SetChoreIsDone()
    {
        _choreDone = false;
    }

    public List<string> _toddlerChores = new List<string> //ages 2-4
    {
        "Pick up toys",
        "Put books on shelf",
        "Put dirty clothes in the basket",
        "Help set the table",
        "Help sweep with a little broom brush"
    };

    public List<string> _lilKidChores = new List<string> //ages 5-7
    {
        "Help set the table",
        "Clear the table",
        "Put away clean utensils and plastic ware",
        "Dust",
        "Clean bathroom"
    };

    public List<string> _bigKidChores = new List<string> //ages 8-11
    {
        "Sweep and Mop",
        "Help clean up dinner",
        "Empty trash from all rooms",
        "Vacuum",
        "Clean bathroom",
        "Clean windows"
    };

    public List<string> _teenChores = new List<string> //ages 12+
    {
        "Help prepare dinner",
        "Help clean up dinner",
        "Take trash to the curb",
        "Help little kids with laundry",
        "Vacuum",
        "Help with grocery Shopping",
        "Clean windows"
    };

    public void AssignedToddler(int i)
    {
        foreach (string item in _toddlerChores)
        {
            if (GetChoreIsDone() == false)
            {
                Console.WriteLine($"{i}. [ ] Toddler - {item}");
            }
            else if (GetChoreIsDone() == true)
            {
                Console.WriteLine($"{i}. [X] Toddler - {item}");
            }
        }
    }
    //Display format of the lists.
    public void AssignedLilKid(int i)
    {
        foreach (string item in _lilKidChores)
        {
            if (GetChoreIsDone() == false)
            {
                Console.WriteLine($"{i}. [ ] Toddler - {item}");
            }
            else if (GetChoreIsDone() == true)
            {
                Console.WriteLine($"{i}. [X] Toddler - {item}");
            }
        }
    }

    public void AssignedBigKid(int i)
    {
        foreach (string item in _bigKidChores)
        {
            if (GetChoreIsDone() == false)
            {
                Console.WriteLine($"{i}. [ ] Toddler - {item}");
            }
            else if (GetChoreIsDone() == true)
            {
                Console.WriteLine($"{i}. [X] Toddler - {item}");
            }
        }
    }

    public void AssignedTeen(int i)
    {
        foreach (string item in _teenChores)
        {
            if (GetChoreIsDone() == false)
            {
                Console.WriteLine($"{i}. [ ] Toddler - {item}");
            }
            else if (GetChoreIsDone() == true)
            {
                Console.WriteLine($"{i}. [X] Toddler - {item}");
            }
        }
    }
}
