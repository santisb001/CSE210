using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Comment
{
    //Attributes
    private string _name;
    private string _text;

    //Constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    //Methods
    public void DisplayComment()
    {
        //Display the comment data
        Console.WriteLine($"{_name}: {_text}");
    }
}