using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is currently empty.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}~~{entry._mood}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found. Please check the name and try again.");
            return;
        }

        _entries.Clear(); 
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            if (parts.Length == 4)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];
                loadedEntry._mood = parts[3];
                
                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}