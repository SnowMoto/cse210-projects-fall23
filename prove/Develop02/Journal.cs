using System;
using System.Diagnostics.Contracts;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>
    {

    };
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public List<Notes> _note = new List<Notes>
    {

    };
    public void AddNotes(Notes newNotes)
    {
        _note.Add(newNotes);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        foreach (Notes notes in _note)
        {
            notes.Display();
        }
    }
    public void SaveFile(string file)
    {
            using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry entry in _entries)
            {
                 outputFile.WriteLine($"{entry._promptText} : {entry._entryText} : {entry._date}");
            }
            foreach (Notes notes in _note)
            {
                outputFile.WriteLine($"{notes._title} : {notes._noteText} : {notes._date}");
            }
        }
    }
    public void LoadFile(string file)
    {
        string[] saveFile = System.IO.File.ReadAllLines(file);
        //Console.WriteLine($"{saveFile}");

        foreach (string line in saveFile)
        {
             Console.WriteLine(line);
             Console.WriteLine();
        }
    }
}