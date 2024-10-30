using System.Transactions;

public class Video
{
   public string Title {get;set;}
   public string Author {get;set;}
   public string Duration {get;set;}
   public List<Comment> Comments { get; set; } = new List<Comment>(); 

   public Video (string title, string author, string duration)
   {

     Title = title;
     Author = author;
     Duration = duration;
     

   }

   public int GetNumberOfComments ()
   {
     return Comments.Count;
   }


    
}
