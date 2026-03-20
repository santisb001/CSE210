using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
//Declare the List
public List<Entry> _entries = new List<Entry>();

//Create display method NOT FINISHED
public void AddEntry(Entry newEntry)
{
    Entry newEntry = new Entry();
    newEntry.Display();
    _entries.Add(newEntry);
}

public void DisplayAll()
{
    foreach (string ent in _entries)
    {
        ent.Display();
    }
}

}