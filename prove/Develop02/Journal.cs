using System.Diagnostics.Contracts;

public class Journal
{
    public List<Entry> _entries = new List<Entry>
    {

    };
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveFile(string Entry)
    {
        
    }
    public void LoadFile(string Entry)
    {

    }
}