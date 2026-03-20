using System;
using System.Collections.Generic;

public class Journal
{
    
//Declare the List
public List<Entry> _entries = new List<Entry>();

//Create display method NOT FINISHED
public void AddEntry(Entry newEntry)
{
    _entries.Add(newEntry);
}

public void DisplayAll()
{
    foreach (string ent in _entries)
    {
        Console.WriteLine($"{ent}");
    }
}

}