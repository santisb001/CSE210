using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    
//Declare the variables
public string _date;
public string _entryText = "";
public string _promptText = "";
public PromptGenerator PGenerator;

//Constructor
public Entry()
    {
        _date = DateTime.Now.ToShortDateString();
        PGenerator = new PromptGenerator();
        _promptText = PGenerator.GetRandomPrompt();
    }

//_promptText = Entry.PGenerator.GetRandomPrompt();
//Create display method 
public void Display()
{
    
    //Console.WriteLine($"{_promptText}");
    //_entryText = Console.ReadLine();
    Console.WriteLine($"{_date} -- {_promptText}: '{_entryText}.");

    
}

}
