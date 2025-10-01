using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Behavior behavior = new Behavior();

        Video video1 = new Video("C# Basics", "Alice", 600);
        Video video2 = new Video("How many hamburguer's I can eat?", "Bob", 1200);
        Video video3 = new Video("Bethoven Piano's Cover", "Carol", 900);

        behavior.AddComment(video1, new Comment("John", "Great explanation!"));
        behavior.AddComment(video1, new Comment("Mary", "Very helpful."));
        behavior.AddComment(video1, new Comment("Sam", "Thanks for sharing!"));

        behavior.AddComment(video2, new Comment("Alice", "There is no reason for eat 12 hamburguers!"));
        behavior.AddComment(video2, new Comment("Tom", "Hahaha, awesome."));
        behavior.AddComment(video2, new Comment("Emma", "Crazy, man!"));
        behavior.AddComment(video2, new Comment("Liam", "I've did it before. But I get fine after use anti-acid !"));

        behavior.AddComment(video3, new Comment("Olivia", "You did Well!"));
        behavior.AddComment(video3, new Comment("Noah", "That's awesome, i loved."));
        behavior.AddComment(video3, new Comment("Ava", "How many times did you play piano?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        behavior.ShowAllVideos(videos);
    }
}