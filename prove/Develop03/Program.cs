using System;

public class Program
{
    public static void Main()
    {
        // Ejemplo de referencia con un versículo
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Mostrar la escritura completa
        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // Termina el programa si el usuario escribe 'quit'
            }

            scripture.HideRandomWords(3); // Oculta 3 palabras aleatoriamente
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. You've completed the exercise!");
                break; // Finaliza cuando todas las palabras están ocultas
            }
        }
    }
}
