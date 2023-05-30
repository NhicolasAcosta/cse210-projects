using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Making firt video and its comments
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Duration = 120,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Commentator 1", CommentText = "comment 1 for video 1" },
                new Comment { CommenterName = "Commentator 2", CommentText = "comment 2 for video 1" },
                new Comment { CommenterName = "Commentator 3", CommentText = "comment 3 for video 1" }
            }
        };
        videos.Add(video1);

        // Making second video and its comments
        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Duration = 180,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Commentator 1", CommentText = "comment 1 for video 2" },
                new Comment { CommenterName = "Commentator 2", CommentText = "comment 2 for video 2" }
            }
        };
        videos.Add(video2);

        // Making third video and its comments
        Video video3 = new Video
        {
            Title = "Video 3",
            Author = "Author 3",
            Duration = 240,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "Commentator 1", CommentText = "comment 1 for video 3" },
                new Comment { CommenterName = "Commentator 2", CommentText = "comment 2 for video 3" },
                new Comment { CommenterName = "Commentator 3", CommentText = "comment 3 for video 3" },
                new Comment { CommenterName = "Commentator 4", CommentText = "comment 4 for video 3" }
            }
        };
        videos.Add(video3);

        // Show the information of the videos and their comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Duration: " + video.Duration + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; }
    public List<Comment> Comments { get; set; }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }
}

