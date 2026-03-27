using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Word
{
    //Atributes
    private string _text;
    private string _textToChange;
    private bool _isHidden;

    //Contructor
    public Word(string text)
    {
        _text = text;
        _textToChange = text;
        _isHidden = false;
    }

    //Methods
    public void Hide()
    {
        //Replace all the characters for '_' --- new string('_', texto.Length);
        _textToChange = new string('_', _text.Length);
        //The output should be "______"
        _isHidden = true;
    }

    public void Show()
    {
        _textToChange = _text;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden; //bool
    }
    public string GetDisplayText()
    {
        return _textToChange; //string
    }
}