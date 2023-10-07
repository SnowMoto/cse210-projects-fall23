public class Notes
{
    public string _date;
    public string _noteText;
    public string _title;

    public void Display ()
    {
        System.Console.WriteLine($"Todo: {_title}:  {_noteText}  :{_date}");
    }
}