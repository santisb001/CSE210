using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
//Declare the List
public List<Entry> _entries = new List<Entry>();
public string _toLoadFile = "";
public string _toSaveFile = ""; 

public string[] _lines;

public string _fileEntries = "";

//Create display method NOT FINISHED
public void AddEntry()
{

    Entry newEntry1 = new Entry();

    Console.WriteLine(newEntry1._promptText);
    newEntry1._entryText = Console.ReadLine();
    
    _entries.Add(newEntry1);
}

public void DisplayAll()
{
    Console.WriteLine();
    Console.WriteLine("Journal entries:");
    foreach (Entry ent in _entries)
    {
        ent.Display();
    }
}

public void SaveToFile()
{   
    //Ask fot the file's name
    Console.WriteLine("Write the file's name: ");
    _toSaveFile = Console.ReadLine();
    
    //Loop
    using (StreamWriter outputFile = new StreamWriter(_toSaveFile))
        {
        foreach (Entry ent in _entries)
        {
            //Write in the file
            outputFile.WriteLine($"{ent._date} -- {ent._promptText}: '{ent._entryText}'");
        } 
    
    }
}
public void LoadFromFile()
{
    //_fileEntries.Clear();

    Console.WriteLine("Write the name of the file you want to load: ");
    _toLoadFile = Console.ReadLine();

    _lines = File.ReadAllLines(_toLoadFile);

    foreach (string l in _lines)
        {
            Console.WriteLine($"{l}");
            //_fileEntries.Add(l);
        }
}


}