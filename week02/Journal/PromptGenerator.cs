using System;
using System.Collections.Generic;


public class PromptGenerator
{
    
//Declare the List
public List<String> _prompts = new List<String>();
string promptsFile = "prompts.txt";
Random rand = new Random();
string[] lines = System.IO.File.ReadAllLines(promptsFile);

public void PromptGenerator()
    {
        foreach (string p in lines)
        {
            _prompts.Add(p);
        }
    }

// It should return a STRING
public string GetRandomPrompt()
{

    int _promptNumber = rand.Next(0,_prompts.Count);

    return _prompts[_promptNumber];
}

}