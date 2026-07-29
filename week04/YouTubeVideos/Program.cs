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

            video1.AddComment(new Comment("Ama", "Very helpful!"));
            video1.AddComment(new Comment("Bob", "Thanks!"));
            video1.AddComment(new Comment("Chris", "Excellent explanation."));

            Video video2 = new Video(
                "Object-Oriented Programming",
                "Code Academy",
                1800);

            video2.AddComment(new Comment("Kofi", "Great lesson!"));
            video2.AddComment(new Comment("Emma", "Easy to follow."));
            video2.AddComment(new Comment("Frank", "Loved it."));

            Video video3 = new Video(
                "C# Collections Explained",
                "Tech World",
                2400);

            video3.AddComment(new Comment("Grace", "Helpful examples."));
            video3.AddComment(new Comment("Henry", "Nice explanation."));
            video3.AddComment(new Comment("Ivy", "Thank you!"));

            Video video4 = new Video(
                "Advanced C# Tips",
                "Coding Pro",
                2700);

            video4.AddComment(new Comment("Jack", "Very informative."));
            video4.AddComment(new Comment("Koku", "Awesome content."));
            video4.AddComment(new Comment("Kay", "Learned a lot."));

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
        }
    }
}
