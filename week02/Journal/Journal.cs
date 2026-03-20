using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
//Declare the List
public List<Entry> _entries = new List<Entry>();

//Create display method NOT FINISHED
public void AddEntry()
{

    Entry newEntry1 = new Entry();

    Console.WriteLine($"{newEntry1._promptText}");
    newEntry1._entryText = Console.ReadLine();

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

public void SaveToFile()
{
    //hgfhgfhjgf
}

public void LoadFromFile()
{
    //gfhgfhgf
}


}