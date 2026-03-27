using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Scripture
{
    //Atributes
    private Reference _reference;
    private List<Word> _words;
    private List<string> _stringList = new List<string>();
    
    private Random _randInt;
    

    //Contructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _randInt = new Random();

        
        //Separate the scripture's string by " ", "," and strip the extra spaces and then create word objects from every separation
        _stringList = text.Split(new char [] {' ', ',','.'}, StringSplitOptions.RemoveEmptyEntries).ToList();
        
        foreach (string i in _stringList)
        {
            Word w = new Word(i);
            _words.Add(w); 
        }
    }

    //Methods
    public void HideRandomWords(int numberToHide)
    {
        //Inicialize the HashSet to not repeat the words
        HashSet<int> _indexes = new HashSet<int>();

        while (_indexes.Count < numberToHide && _indexes.Count < _words.Count)
        {
            int num = _randInt.Next(0, _words.Count);
            _indexes.Add(num);
        }

        //Hide the selected words
        foreach (int i in _indexes)
        {
            _words[i].Hide();
        }
    }

    public string GetDisplay()
    {
        string _display = " ";
        foreach (Word w in _words )
        {
            _display += " " + w.GetDisplayText();
        }
        return _display.Trim(); //string
    }

    public bool IsCompletelyHidden()
    {
        //
        return true; //bool
    }


}