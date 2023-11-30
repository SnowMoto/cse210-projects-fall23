public class ChoreIdeas
{
    private bool _choreComplete;

    public bool GetChoreComplete()
    {
        return _choreComplete;
    }
    public List<string> _toddlerChores = new List<string>
    {
        "Pick up toys",
        "Put books on shelf",
        "Put dirty clothes in the basket",
        "Help set the table",
        "Help sweep with a little broom brush"
    };

    public List<string> _lilKidChores = new List<string>
    {
        "Pick up toys",
        "Put books on shelf",
        "Put dirty clothes in the basket",
        "Help set the table",
        "Help sweep with a little broom brush"
    };

    public List<string> _bigKidChores = new List<string>
    {
        "Pick up toys",
        "Put books on shelf",
        "Put dirty clothes in the basket",
        "Help set the table",
        "Help sweep with a little broom brush"
    };

    public List<string> _teenChores = new List<string>
    {
        "Pick up toys",
        "Put books on shelf",
        "Put dirty clothes in the basket",
        "Help set the table",
        "Help sweep with a little broom brush"
    };
    public void AssignedChores(int i)
    {
        foreach (string item in _toddlerChores)
        {
            if (GetChoreComplete()== false)
            {
                Console.WriteLine($"{i}. [ ] {item}");
            }    
            else if (GetChoreComplete() == true)
            {
                Console.WriteLine($"{i}. [X] {item}");
            }
        }

        foreach (string item in _lilKidChores)
        {
            if (GetChoreComplete()== false)
            {
                Console.WriteLine($"{i}. [ ] {item}");
            }    
            else if (GetChoreComplete() == true)
            {
                Console.WriteLine($"{i}. [X] {item}");
            }
        }

        foreach (string item in _bigKidChores)
        {
            if (GetChoreComplete()== false)
            {
                Console.WriteLine($"{i}. [ ] {item}");
            }    
            else if (GetChoreComplete() == true)
            {
                Console.WriteLine($"{i}. [X] {item}");
            }
        }

        foreach (string item in _teenChores)
        {
            if (GetChoreComplete()== false)
            {
                Console.WriteLine($"{i}. [ ] {item}");
            }    
            else if (GetChoreComplete() == true)
            {
                Console.WriteLine($"{i}. [X] {item}");
            }
        }
    }
}