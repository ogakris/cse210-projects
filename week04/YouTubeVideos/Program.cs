using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video(
    "Learn C# in One Hour",
    "Programming Hub",
    3600);

video1.AddComment(new Comment("Alice", "Very helpful!"));
video1.AddComment(new Comment("Bob", "Thanks!"));
video1.AddComment(new Comment("Chris", "Excellent explanation."));
            List<Video> videos = new List<Video>();

videos.Add(video1);
videos.Add(video2);
videos.Add(video3);
videos.Add(video4);
            foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video.GetTitle()}");
    Console.WriteLine($"Author: {video.GetAuthor()}");
    Console.WriteLine($"Length: {video.GetLength()} seconds");
    Console.WriteLine($"Comments: {video.GetCommentCount()}");

    foreach (Comment comment in video.GetComments())
    {
        Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
    }

    Console.WriteLine();
}
        
 
