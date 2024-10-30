using System;

class Program
{
    static void Main(string[] args)
    {
       //videos 

       Video video1 = new Video ("Learning Python", "Adam Morris", "600");
       Video video2 = new Video ("How to code", "Jhon Mahommes", "700");
       Video video3 = new Video ("What is Csharp?", "Oscar Salazar", "569");

       //comments

       video1.Comments.Add ( new Comment ("Mario", "This was very helpful!"));
       video1.Comments.Add (new Comment ("Marcos","I didn't like the video at all."));

       video2.Comments.Add (new Comment ("Juan", "need transalation please."));
       video2.Comments.Add (new Comment ("Charlie", "first comment!"));

       video3.Comments.Add (new Comment ("Peter", "now i uderstand Csharp!"));
       video3.Comments.Add (new Comment ("Jhon", "i don't get it!!")); 

       //list
       List<Video> videos = new List<Video> {video1,video2,video3};

       //information video and comment

       foreach (var video in videos)
       {
        Console.WriteLine ($"Title: {video.Title}, Author: {video.Author}, Length: {video.Duration} seconds");
        Console.WriteLine ($"Number of comments {video.GetNumberOfComments()}");

        foreach (var comment in video.Comments)
        {
            Console.WriteLine ($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();


       }



    }
}