using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create Video Objects
        Video video1 = new Video("C# Basics Tutorial", "Codecademy", 600);
        Video video2 = new Video("Object-Oriented Programming Principles", "Tech Explained", 1200);
        Video video3 = new Video("Understanding Lists & Collections", "Dev Tips", 450);
        Video video4 = new Video("Top 10 VS Code Extensions", "Tool Time", 900);

        // 2. Add Comments to Video 1
        video1.AddComment(new Comment("Alice", "Great introduction to C#!"));
        video1.AddComment(new Comment("Bob", "Super helpful, thanks for uploading."));
        video1.AddComment(new Comment("Charlie", "Can you cover async/await next?"));

        // Add Comments to Video 2
        video2.AddComment(new Comment("Dave", "Abstraction finally makes sense to me."));
        video2.AddComment(new Comment("Eve", "Awesome explanations and diagrams."));
        video2.AddComment(new Comment("Frank", "Shared this with my study group!"));
        video2.AddComment(new Comment("Grace", "Clear and concise."));

        // Add Comments to Video 3
        video3.AddComment(new Comment("Heidi", "Lists are so much cleaner than arrays."));
        video3.AddComment(new Comment("Ivan", "Short and straight to the point."));
        video3.AddComment(new Comment("Judy", "Loved the code examples."));

        // Add Comments to Video 4
        video4.AddComment(new Comment("Mallory", "Installed three of these immediately!"));
        video4.AddComment(new Comment("Oscar", "Bracket Pair Colorizer is a lifesaver."));
        video4.AddComment(new Comment("Peggy", "Nice list! Thanks!"));

        // 3. Put Videos into a List
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // 4. Iterate and Display Video Details & Comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: \"{comment.GetText()}\"");
            }

            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
        }
    }
}
