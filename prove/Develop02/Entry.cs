using System;
using System.IO;

public class Entry
{
    public string _prompt;

    public string _response;

    public string _newEntry;

    public string _fileName;

    public DateTime _dateAndTime = DateTime.Now;
    internal DateTime _entryDate;

    public void DisplayEntries(List<string> _userResponses)
    {
        foreach (string response in _userResponses)
        Console.WriteLine($"{response}");
    }

public void SaveEntry(string _fileName, string _newEntry)
    {
        string _entry = $"{_newEntry}";
        // Check if directory exists, and creates it if it doesn't, then saves entry to that text file
        string dir = $@"C:\Journal\{_fileName}\Entry.txt";
        if (Directory.Exists(dir))
        { 
            File.WriteAllText(Path.Combine($@"C:\Journal\{_fileName}", "Entry.txt"), _entry);
        }
        else
        {
            Directory.CreateDirectory($@"C:\Journal\{_fileName}");
            File.AppendAllText(Path.Combine(dir), _entry);
        }

    }
}
