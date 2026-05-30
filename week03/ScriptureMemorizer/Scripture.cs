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

        // Split the text block into individual Word objects
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Create a list of only the words that are still visible
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        
        // Prevent crashing if the user asks to hide more words than are left
        int iterations = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < iterations; i++)
        {
            // Pick a random visible word, hide it, and remove it from the temporary list
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); 
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        
        return $"{_reference.GetDisplayText()} {scriptureText.TrimEnd()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            // If even one word is not hidden, return false
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}