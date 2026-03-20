using System;
using System.Collections.Generic;





public class Entry
{
    
//Declare the variables
public string _date = DateTime.Now.ToShortDateString();
public string _promptText = PromptGenerator.GetRandomPrompt();
public string _entryText = "";

//Create display method NOT FINISHED
public void Display()
{
    
    //Console.WriteLine($"{_promptText}");
    _entryText = Console.ReadLine();
    Console.WriteLine($"{_date} -- {_promptText}: {_entryText}");
}

}