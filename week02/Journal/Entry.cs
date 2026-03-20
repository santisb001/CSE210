using System;
using System.Collections.Generic;

DateTime theCurrentTime = DateTime.Now();



public class Entry
{
    
//Declare the variables
public string _date = theCurrentTime.ToShortDateString();
public string _promptText = "";
public string _entryText = "";

//Create display method NOT FINISHED
public void Display()
{
    Console.WriteLine($"{_promptText}");
    _entryText = Console.ReadLine();
    //Console.WriteLine($"{_date} -- {_promptText}: {_entryText}");
}

}