using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Método para agregar una nueva entrada
    public void AddEntry()
    {
        Random random = new Random();
        int promptIndex = random.Next(prompts.Count);
        string selectedPrompt = prompts[promptIndex];

        Console.WriteLine(selectedPrompt);
        string response = Console.ReadLine();

        Entry newEntry = new Entry(selectedPrompt, response);
        entries.Add(newEntry);
    }

    // Método para mostrar todas las entradas
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    // Método para guardar el diario en un archivo
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    // Método para cargar el diario desde un archivo
    public void LoadFromFile(string filename)
    {
        entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2]);
                    entry.Date = parts[0]; // Sobrescribe la fecha con la que está en el archivo
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
