using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Video 1
            Video video1 = new Video("C# Abstraction Tutorial", "TechWithTim", 600);
            video1.AddComment(new Comment("Alice", "Great explanation of OOP concepts!"));
            video1.AddComment(new Comment("Bob", "This really helped me understand classes."));
            video1.AddComment(new Comment("Charlie", "Can you make a video on polymorphism next?"));
            videos.Add(video1);

            // Video 2
            Video video2 = new Video("Top 10 VS Code Tips & Tricks", "CodeAcademy", 480);
            video2.AddComment(new Comment("Dave", "The multi-cursor shortcut changed my life!"));
            video2.AddComment(new Comment("Eva", "Thanks for the recommendations."));
            video2.AddComment(new Comment("Frank", "Super helpful video!"));
            videos.Add(video2);

            // Video 3
            Video video3 = new Video("How to Build a Console App in .NET", "DevGuide", 900);
            video3.AddComment(new Comment("Grace", "Clear and concise explanation."));
            video3.AddComment(new Comment("Heidi", "Followed along and everything worked perfectly."));
            video3.AddComment(new Comment("Ivan", "Awesome content as always!"));
            videos.Add(video3);

            // Video 4
            Video video4 = new Video("Product Placement Analysis in 2026", "MarketInsights", 750);
            video4.AddComment(new Comment("Judy", "Fascinating look at modern marketing strategies."));
            video4.AddComment(new Comment("Kevin", "Very informative, thanks!"));
            video4.AddComment(new Comment("Laura", "I never noticed that brand placement before."));
            videos.Add(video4);

            // Iterate through the list of videos and display details
            foreach (Video video in videos)
            {
                video.DisplayVideoInfo();
            }
        }
    }
}
