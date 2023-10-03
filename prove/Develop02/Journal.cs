using System;
using System.Collections.Generic;

public class Display{
    public List<Entry> _entries = new List<Entry>();
    
    //Methods
    public void entryDisplay(){
        
        foreach (Entry elementEntry in _entries)
        {
         elementEntry.Display();
         
        }
    }

    }