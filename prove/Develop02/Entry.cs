public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display ()
    {
        System.Console.WriteLine($"{_promptText} {_entryText} {_date}");
    }
    
}