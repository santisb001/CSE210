using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Video
{
    //Attributes
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
        _comments = new List<Comment>();
    }

    //Methods
    public void ExpandCommentList(string nameV, string textV)
    {   
        Comment commentMade = new Comment(nameV,textV);

        _comments.Add(commentMade);
    }
    public int ReturnNumOfComments()
    {
        //Count and return the number of items in the Comment list.
        return _comments.Count();//int 
    }

    public void DisplayVideo()
    {
        //Display the video data and the comment data, by calling the display method of the Comment Class.
        Console.WriteLine("------ VIDEO ------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"YouTube channel: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}s");
        int counter = ReturnNumOfComments();
        Console.WriteLine($"Number of comments in thuis video: {counter}");
        Console.WriteLine($"Comments: ");
        foreach (Comment c in _comments)
        {
            c.DisplayComment();
        }

    }









}