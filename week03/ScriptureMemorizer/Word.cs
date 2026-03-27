using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Word
{
    //Atributes
    private string _text;
    private bool _isHidden;

    //Contructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Methods
    public void Hide()
    {
        //Replace all the characters for '_' --- new string('_', texto.Length);
        _text = new string('_', _text.Length);
        //The output should be "______"

    }

    public void Show()
    {
        Console.WriteLine($"{_text}");
        
    }

    public bool IsHidden()
    {
        _isHidden = true;
        return _isHidden; //bool
    }
    public string GetDisplayText()
    {
        return _text; //string
    }





}