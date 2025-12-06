using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void AppendEntry(Entry e)
    {
        _entryList.Add(e);
    }

    public void DisplayEntries()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (Entry entry in _entryList)
        {
            entry.Display();
            Console.WriteLine("------------");
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Enter the file you want to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entryList)
            {
                writer.WriteLine($"Date: {entry._entryDateTime}");
                writer.WriteLine($"Prompt: {entry._givenPrompt}");
                writer.WriteLine($"Response: {entry._entryText}");
                writer.WriteLine("-----"); // separator
            }
        }

        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFile(string filename)
    {
        try
        {
            _entryList.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string dateLine = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(dateLine)) break;

                    string promptLine = reader.ReadLine();
                    string responseLine = reader.ReadLine();
                    reader.ReadLine(); // skip "-----"

                    string date = dateLine.Substring(6);
                    string prompt = promptLine.Substring(8);
                    string response = responseLine.Substring(10);

                    Entry entry = new Entry(date, prompt, response);
                    _entryList.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (IOException)
        {
            Console.WriteLine("Error loading the journal from the file.");
        }
    }
}
