using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Assignment
{
    //Attributes
    protected string _studentName;
    private string _topic;

    //Constructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    
    //Methods
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    //public string GetName()
    //{
    //    return _studentName;
    //}

}