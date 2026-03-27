using System;
using System.Collections.Generic;
using System.IO;

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
        _isHidden = true;
        
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
        if (_isHidden == true)
        {
            _text = _text;
        }
        else if (_isHidden == false)
        {
            _text = "_";
        }
        return _text; //string
    }





}