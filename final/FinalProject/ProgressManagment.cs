using System;
using System.ComponentModel.Design;
using System.Security.Authentication.ExtendedProtection;

public class ProgressManagement
{
    private List<Chores> _chores;
    private List<ChoreIdeas> _assign;
    private List<GoodHabits> _habit;
    private string _earned;
    private string _bonus;

    public ProgressManagement()
    {
        _chores = new List<Chores>();
        _assign = new List<ChoreIdeas>();
        _habit = new List<GoodHabits>();
    }

    public string Bonus()
    {
        return _bonus;
    }

    public string GetReward()
    {
        return _earned;
    }

    public string GetBonus()
    {
        return _bonus;
    }

    public string DisplayReward()
    {
        return _earned;
    }

    //Create chore list or use pre-designed list using switch to identify what type of list.
    public void AddChore(int ageGroup)
    {
        string addChoreName;
        Chores chore;
        ChoreIdeas assign;
        Console.WriteLine("Do you need chore ideas?");
        Console.Write("");
        string answer = Console.ReadLine();

        if (answer == "n")
        {
            Console.WriteLine("\nCreate a Chore List: ");

            addChoreName = Console.ReadLine();
            switch (ageGroup) // User creates and adds to a Chore List.
            {
                case 1:
                    chore = new Toddler("Toddler", addChoreName, false);
                    break;

                case 2:
                    chore = new LittleKid("Little Kid", addChoreName, false);
                    break;

                case 3:
                    chore = new BigKid("Big Kid", addChoreName, false);
                    break;

                case 4:
                    chore = new Teen("Teen", addChoreName, false);
                    break;

                default:
                    chore = new Toddler();
                    break;
            }
            _chores.Add(chore);
        }
        else
        {
            switch (ageGroup) //User selects a pre-designed list.
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
                        LittleKid lilKid = new LittleKid("Little Kid", lilkidchore, false);
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
                        Teen teen = new Teen("Teen", teenchore, false);
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

        Console.WriteLine($"Reward for completing chores? ");
        _earned = Console.ReadLine();

        Console.WriteLine($"Bonus for completing Good Habits? ");
        _bonus = Console.ReadLine();
    }

    //Iterate through Chores List and pre-designed lists.
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
            Console.WriteLine("\nCreate New Chores!");
        }
        return _chores;
    }

    //Record chores from either lists by entering the chore number to be selected at complete.
    public void RecordChore()
    {
        ListOfChores();
        Console.Write("\nWhich chore did you accomplish? Enter number or 0 if none:  ");

        if (_chores.Count() > 0)
        {
            int select = int.Parse(Console.ReadLine()) - 1;
            _chores[select].SetChoreISCompelte();
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Need more chores to complete.");
        }
    }

    //Save chores lists into a txt by childs name with same format with check boxes.
    public void SaveChore()
    {
        Console.Write("\nSave by childs name:  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            int i = 1;
            foreach (Chores chore in _chores)
            {
                if (chore.GetChoreIsComplete() == false)
                {
                    outputFile.WriteLine($"{i}. [ ] {chore.GetName()} - {chore.GetChoreName()} ");
                    i = i + 1;
                }
                else if (chore.GetChoreIsComplete() == true)
                {
                    outputFile.WriteLine($"{i}. [X] {chore.GetName()} - {chore.GetChoreName()}");
                    i = i + 1;
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"{i}. [ ] {assign._toddlerChores}");
                    i = i + 1;
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"{i}. [X] {assign._toddlerChores}");
                    i = i + 1;
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"{i}. [ ] {assign._lilKidChores}");
                    i = i + 1;
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"{i}. [X] {assign._lilKidChores}");
                    i = i + 1;
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"{i}. [ ] {assign._bigKidChores}");
                    i = i + 1;
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"{i}. [X] {assign._bigKidChores}");
                    i = i + 1;
                }
            }
            foreach (ChoreIdeas assign in _assign)
            {
                if (assign.GetChoreIsDone() == false)
                {
                    outputFile.WriteLine($"{i}. [ ] {assign._teenChores}");
                    i = i + 1;
                }
                else if (assign.GetChoreIsDone() == true)
                {
                    outputFile.WriteLine($"{i}. [X] {assign._teenChores}");
                    i = i + 1;
                }
            }
            outputFile.WriteLine($"Reward for all Chores Complete: {DisplayReward()}");
            outputFile.WriteLine($"Bonus if Good Habits Complete: {Bonus()}");
        }
    }

    //Load txt file by childs saved name and update chore progress file.
    public void UpdateChore()
    {
        Console.Write("\nEnter the child's name to load progress: ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] lines = File.ReadAllLines(userFileName);

            Console.WriteLine($"Chore List for {userFileName}:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.Write("\nEnter chore number completed: ");
            int select = int.Parse(Console.ReadLine()) - 1;

            if (select >= 0 && select < _chores.Count)
            {
                _chores[select].SetChoreISCompelte();

                lines[select] = $"{lines[select].Substring(0, 4)}X{lines[select].Substring(5)}";

                File.WriteAllLines(userFileName, lines);

                Console.WriteLine("File loaded and updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid chore number.");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
