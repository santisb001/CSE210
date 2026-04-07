using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Activity
{
    //Attributes
    private string _name;
    private string _description;
    private int _duration;

    //Constructor
    public Activity(string actName, string description, int time)
    {
        _name = actName;
        _description = description;
        _duration = 0;
    }

    public int SetDuration(int time)
    {
        _duration = time;
    } 

    
    //Methods
    public void DisplayStartingMessage()
    {
        //
    }
    public void DisplayEndingMessage()
    {
        //
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