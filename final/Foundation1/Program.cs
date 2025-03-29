using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video = new Video("Exploring C# Abstractions", "C# at Home", 800);
        video.AddComment(new Comment("Alice", "Great video, very informative!"));
        video.AddComment(new Comment("Bob", "Loved the explanations."));
        video.AddComment(new Comment("Charlie", "Looking forward to more content!"));

        video.DisplayVideoInfo();
    }
}
