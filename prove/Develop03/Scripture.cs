using System;
using System.Collections.Generic;

public class Scripture
{
    // attributes
    private List<Word> _words;
    private Random _random;
    // behaviors
    public Scripture(string scripture)
    {
        _words = new List<Word>();
        _random = new Random();

        string[] split = scripture.Split(' ');
        foreach (string w in split)
        {
            _words.Add(new Word(w));
        }
    }
    public bool AllHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                return false;
        }
        return true;
    }
    public void HideWords(int count)
    {
        List<Word> remainingWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
                remainingWords.Add(w);
        }

        if (remainingWords.Count == 0)
            return;

        int hideCount = Math.Min(count ,remainingWords.Count);
        for(int i=0; i < hideCount; i++)
        {
            int index = _random.Next(remainingWords.Count);
            remainingWords[index].Hide();
            remainingWords.RemoveAt(index);
        }
    }
    public string GetScripture()
    {
        List<string> output = new List<string>();

        foreach (Word w in _words)
        {
            output.Add(w.Display());
        }
        return string.Join(" ", output);
    }
}