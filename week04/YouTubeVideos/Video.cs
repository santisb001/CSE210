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
    public void ExpandCommentList(Comment passedComment)
    {
        _comments.Add(passedComment);
    }
    public int ReturnNumOfComments(List<Comment> commentList)
    {
        //Count and return the number of items in the Comment list.
        int numberOfComments = commentList.Count();
        return numberOfComments;//int 
    }

    public void DisplayVideo()
    {
        //Display the video data and the comment data, by calling the display method of the Comment Class.

    }









}