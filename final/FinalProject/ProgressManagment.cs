using System;
using System.Security.Authentication.ExtendedProtection;

public class ProgressManagement
{
    private List<Chores> _chores;
    public ProgressManagement()
    {
        _chores = new List<Chores>();
    }
    public void AddChore(int ageGroup)
    {
        string addChoreName;
        Chores chore;
        Console.WriteLine("Do you need chore ideas?");
        Console.Write("");
        string answer = Console.ReadLine();

        if (answer == "N")
        {
            Console.WriteLine("Create a Chore List: ");
            addChoreName = Console.ReadLine();
            switch (ageGroup)
            {
                case 1:
                chore = new Toddler("Toddler", "", addChoreName, false);
                break;

                case 2:
                chore = new LittleKid("Little Kid","",addChoreName, false);
                break;

                case 3:
                chore = new BigKid("Big Kid","",addChoreName, false);
                break;

                case 4:
                chore = new Teen("Teen","",addChoreName, false);
                break;

                default:
                chore = new Toddler();
                break;
            }
        }
        else
        {
            switch(ageGroup)
            {
                case 1:
                chore = new Toddler();
                break;

                case 2:
                chore = new LittleKid();
                break;

                case 3:
                chore = new BigKid();
                break;

                case 4:
                chore = new Teen();
                break;

                default:
                chore = new Toddler();
                break;
            }     
        }
        _chores.Add(chore);
    }
    public void DisplayProgress()
    {
        foreach (Chores chore in _chores)
        {
            chore.DisplayProgress(_chores);
        }
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
    
        //for (int i = 0; i < _chores.Count; i++)
        //{
        //    _chores[i].ParentChoreList(i);
        //}   
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
                outputFile.WriteLine(ListOfChores());
        }
    }
}