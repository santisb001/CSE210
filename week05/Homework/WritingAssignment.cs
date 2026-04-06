using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class WritingAssignment : Assignment
{
    //Attributes
    private string _title;

    //Constructor
    public WritingAssignment(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }

    //Methods
    public string GetWitingInformation()
    {
        return _title + " by " + _studenName;
    }

}