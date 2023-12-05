using System;
using System.Security.Authentication.ExtendedProtection;

public class ProgressManagement
{
    private List<Chores> _chores;
    private List<ChoreIdeas> _assign;
    private List<Rewards> _earned;
    public ProgressManagement()
    {
        _chores = new List<Chores>();
        _assign = new List<ChoreIdeas>();
        _earned = new List<Rewards>();
    }
    public void AddChore(int ageGroup)
    {
        string addChoreName;
        Chores chore;
        ChoreIdeas assign;
        Console.WriteLine("Do you need chore ideas?");
        Console.Write("");
        string answer = Console.ReadLine();

        if (answer == "n")// figure out the while loop to continue to add chores before returning to menu
        {
            Console.WriteLine("\nCreate a Chore List: ");

            addChoreName = Console.ReadLine();
            switch (ageGroup)
            {
                    case 1:
                    chore = new Toddler("Toddler", addChoreName, false);
                    break;

                    case 2:
                    chore = new LittleKid("Little Kid",addChoreName, false);
                    break;

                    case 3:
                    chore = new BigKid("Big Kid",addChoreName, false);
                    break;

                    case 4:
                    chore = new Teen("Teen",addChoreName, false);
                    break;

                    default:
                    chore = new Toddler();
                    break;

            }
            _chores.Add(chore);
        }            
            
        else
        {
            switch(ageGroup)
            {
                case 1:
                assign = new ChoreIdeas();
                    foreach (string toddlerchore in assign._toddlerChores)
                    {
                        Toddler toddler = new Toddler("Toddler", toddlerchore, false);
                        _chores.Add(toddler);                   
                    }
                break;

                case 2:
                assign = new ChoreIdeas();
                    foreach (string lilkidchore in assign._lilKidChores)
                    {
                        LittleKid lilKid = new LittleKid ("Little Kid", lilkidchore, false);
                        _chores.Add(lilKid);                   
                    }
                break;

                case 3:
                assign = new ChoreIdeas();
                    foreach (string bigkidchore in assign._bigKidChores)
                        {
                            BigKid bigkid = new BigKid("Big Kid", bigkidchore, false);
                            _chores.Add(bigkid);                   
                        }                    
                break;

                case 4:
                assign = new ChoreIdeas();
                    foreach (string teenchore in assign._teenChores)
                    {
                        Teen teen = new Teen("Toddler", teenchore, false);
                        _chores.Add(teen);                   
                    }
                break;

                default:
                assign = new ChoreIdeas();
                    foreach (string toddlerchore in assign._toddlerChores)
                    {
                        Toddler toddler = new Toddler("Toddler", toddlerchore, false);
                        _chores.Add(toddler);                   
                    } 
                break;
            }   
            ListOfChores();
        }
                    Console.WriteLine($"What reward do they earn? ");
                    string childReward = Console.ReadLine();
                    Rewards rewards = new Rewards(childReward);
                    _earned.Add(rewards);
    }

    public List<Chores> ListOfChores()
    {
        if (_chores.Count() > 0)
        {
            Console.WriteLine("\nYour Chores are:");

            int index = 1;
            foreach (Chores chore in _chores)
            {
                chore.ParentChoreList(index);
                index = index + 1;
            }
            foreach (ChoreIdeas assign in _assign)
            {
                assign.AssignedToddler(index);
                index = index + 1;
            }
            foreach (ChoreIdeas assign in _assign)
            {
                assign.AssignedLilKid(index);
                index = index + 1;
            }
            foreach (ChoreIdeas assign in _assign)
            {
                assign.AssignedBigKid(index);
                index = index + 1;
            }
            foreach (ChoreIdeas assign in _assign)
            {
                assign.AssignedTeen(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no chores!");
        }
        return _chores;
    }
    public void RecordChore()
    {
        ListOfChores();

        Console.Write("\nWhich chore did you accomplish? Enter chore number:  ");
    
        /*for (int i = 0; i < _chores.Count; i++)
        {
           _chores[i].ParentChoreList(i);
        }*/   
        int select = int.Parse(Console.ReadLine())-1;
        _chores [select].SetChoreISCompelte();
    }
    public void SaveChore()
    {
        Console.Write("\nSave by childs name:  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            foreach (Chores chore in _chores ) 
            {
                if (chore.GetChoreIsComplete() == false)
                {
                    outputFile.WriteLine($"[ ] {chore.GetName()} - {chore.GetChoreName()} - {_earned} ");
                }
                else if (chore.GetChoreIsComplete() == true)
                {
                    outputFile.WriteLine($"[X] {chore.GetName()} - {chore.GetChoreName()} - {_earned}");
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"[ ] {assign._toddlerChores} - {_earned}");
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"[X] {assign._toddlerChores} - {_earned}");
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"[ ] {assign._lilKidChores} - {_earned}");
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"[X] {assign._lilKidChores} - {_earned}");
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"[ ] {assign._bigKidChores} - {_earned}");
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"[X] {assign._bigKidChores} - {_earned}");
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"[ ] {assign._teenChores} - {_earned}");
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"[X] {assign._teenChores} - {_earned}");
                }
            }
        }
    }
    public void LoadChore()
    {
        Console.Write("\nWhat is the childs name?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";
        StreamReader sr = new StreamReader(userFileName);
        string line = sr.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }
        sr.Close();
        Console.ReadLine();
    }
}