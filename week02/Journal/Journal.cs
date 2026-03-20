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
    Entry newEntry1 = new Entry();
    newEntry1.Display();
    _entries.Add(newEntry1);
}

public void DisplayAll()
{
    foreach (Entry ent in _entries)
    {
        ent.Display();
    }
}

}