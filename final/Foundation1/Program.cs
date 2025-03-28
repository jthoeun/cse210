using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Video video = new Video("Learning C#", "John Doe", 300);
        video.AddComment(new Comment("Alice", "Great video!"));
        video.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video.AddComment(new Comment("Charlie", "I learned a lot."));
        video.DisplayVideoInfo();
    }
}
