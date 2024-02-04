using System.Net;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public int _saved;

    public string LoadEntry(string _fileName)
    {
        string dir = $@"C:\Journal\{_fileName}";
        string entry = File.ReadAllText(dir + "\\Entry.txt");
        return entry;
    }
}
