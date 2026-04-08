using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructor
    public Activity(string actName, string description)
    {
        _name = actName;
        _description = description;
        _duration = 0;
    }

    //Getters and Setters
    public void SetDuration(int time)
    {
        _duration = time;
    }
    public int GetDuration()
    {
        return _duration;
    }

    
    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}! {_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job! You did another {_duration} seconds of {_name}");
    }

    public void ShowSPinner(int seconds)
    {
        //
    }

    public void ShowCountDown(int seconds)
    {
        //
    }
}