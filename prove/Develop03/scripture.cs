using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Separar el texto en palabras y crear objetos Word
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word)); // Crear un objeto Word por cada palabra
        }
    }

    public void HideRandomWords(int numberOfWordsToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide(); // Delegar la ocultación de la palabra a la clase Word
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true; // Si todas las palabras están ocultas, retorna true
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", _words);
        return $"{_reference}\n{scriptureText}"; // Muestra la referencia y el texto de la escritura
    }
}
