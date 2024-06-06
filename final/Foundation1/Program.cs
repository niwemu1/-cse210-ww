using System;
class Program
{
    public static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create video 1 with comments
        Video video1 = new Video("Nature Documentary", "Moise Attenborough", 1000);
        video1.AddComment(new Comment("Alice", "Beautiful scenery!"));
        video1.AddComment(new Comment("Bob", "Learned a lot about different animals."));
        video1.AddComment(new Comment("Sam", "Would love to see this in person."));
        videos.Add(video1);

        // Create video 2 with comments
        Video video2 = new Video("Coding Tutorial", "Programming Guru", 500);
        video2.AddComment(new Comment("Emily", "Very helpful explanation, thanks!"));
        video2.AddComment(new Comment("Fred", "A bit fast-paced, but informative."));
        video2.AddComment(new Comment("George", "Need to practice more!"));
        videos.Add(video2);

        // Create video 3 with comments
        Video video3 = new Video("Music Review", "Peter", 100);
        video3.AddComment(new Comment("Molly", "Interesting analysis."));
        video3.AddComment(new Comment("Esther", "Great song choices."));
        video3.AddComment(new Comment("Erick", "Looking forward to next review."));
        videos.Add(video3);


        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"** Video Information **");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine($"\n** Comments **");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
            Console.WriteLine("\n"); // Add a newline for separation between videos
        }
    }
}