using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the master list to hold all videos
        List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video v1 = new Video("Building a Banking API with Django", "DevHub", 1200);
        v1.AddComment(new Comment("CodeMaster", "This really helped me with my backend views."));
        v1.AddComment(new Comment("Favvy", "Great explanation, very easy to follow!"));
        v1.AddComment(new Comment("TechNinja", "Will you cover React integration next?"));
        videos.Add(v1);

        // --- Video 2 ---
        Video v2 = new Video("Asphalt Legends Dual Controller Setup", "GamerTech", 850);
        v2.AddComment(new Comment("SpeedRacer", "Can I use PS4 controllers on Windows 11?"));
        v2.AddComment(new Comment("PlayerOne", "The graphic settings tweak fixed my lag, thanks!"));
        v2.AddComment(new Comment("NoobMaster", "Awesome tutorial."));
        videos.Add(v2);

        // --- Video 3 ---
        Video v3 = new Video("Port Harcourt Live Music Showcase", "Naija Beats", 2100);
        v3.AddComment(new Comment("AfroFan", "The band was incredible."));
        v3.AddComment(new Comment("MusicLover", "I absolutely cannot do without this kind of music."));
        v3.AddComment(new Comment("LocalGuide", "What venue was this at?"));
        videos.Add(v3);

        // Iterate through the list and display everything
        Console.Clear();
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}