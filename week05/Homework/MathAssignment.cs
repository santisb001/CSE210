using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MathAssignment : Assignment
{
    //Attributes
    private string _textBookSection;
    private string _problems;
    //Contructor
    public MathAssignment(string section, string problems, string name, string topic) : base(name, topic)
    {
        _textBookSection = section;
        _problems = problems;
    }
    //Methods
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}