using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string unserInput= Console.ReadLine() ;
        int percentGrade = int.Parse (unserInput);

        string letter = " ";

        if (percentGrade >= 90)
        {
            letter = "A";
        }
        else if (percentGrade >= 80)
        {
            letter = "B";
            
        }
        else if (percentGrade >= 70)
        {
            letter = "C";
        }
        else if (percentGrade >= 60)
        {
            letter = "D";
        }
        else if (percentGrade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your Final Grade is {letter}.");
        
        if (percentGrade >= 70)
        {
            Console.WriteLine ("You have passed. Congratulations!");
        }
        else 
        {
            Console.WriteLine ("Better luck next time!"); 
        }
































    }   
}