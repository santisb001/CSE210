using System;
using System.Collections.Generic;
using System.IO;


public class PromptGenerator
{
    
//Declare the List
public List<String> _prompts = new List<String>();
string promptsFile = "prompts.txt";
Random rand = new Random();
string[] lines = File.ReadAllLines(promptsFile);

// It should return a STRING
public string GetRandomPrompt()
{
    _prompts.Clear();
    
    foreach (string p in lines)
        {
            _prompts.Add(p);
        }
    int _promptNumber = rand.Next(0,_prompts.Count);

    return _prompts[_promptNumber];

    
}

}