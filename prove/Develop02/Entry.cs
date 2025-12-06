class Entry
{
    // attributes
    public string _givenPrompt;
    public string _entryDateTime;
    public string _entryText;

    // constructor
    public Entry(string prompt, string text)
    {
        _givenPrompt = prompt;
        _entryText = text;
        _entryDateTime = DateTime.Now.ToString("M/d/yyyy h:mm:ss tt");
    }

    // constructor used for loading existing entries
    public Entry(string date, string prompt, string text)
    {
        _entryDateTime = date;
        _givenPrompt = prompt;
        _entryText = text;
    }

    // behavior
    public void Display()
    {
        Console.WriteLine($"{_entryDateTime} -- { _givenPrompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}
