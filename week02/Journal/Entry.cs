using System;
using System.Collections.Generic;


public class Entry
{
    
//Declare the variables
public string _date = "";
public string _promptText = "";
public string _entryText = "";

public void Display()
{
    Console.WriteLine($"{_date} {_entryText} {_promptText}");
}

}