using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magical number?");
        string userNumber = Console.ReadLine ();
        float magicNumber = float.Parse(userNumber);
        

                float guess = -1;

        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = float.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    
    }

}