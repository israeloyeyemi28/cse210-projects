// Represents a journal containing a list of entries
public class Journal
{
    private List<Entry> _entries;

    // Constructor to create a journal with an empty list of entries
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Adds a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Returns the list of entries in the journal
    public List<Entry> GetEntries()
    {
        return _entries;
    }

    // Saves the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                string entryData = $"{entry.GetDate().ToShortDateString()}|{entry.GetPrompt()}|{entry.GetContent()}";
                outputFile.WriteLine(entryData);
            }
        }
    }

    // Loads the journal from a file, replacing any existing entries
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clears existing entries before loading from file

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Date date = new Date();
            string prompt = parts[1];
            string content = parts[2];

            Entry entry = new Entry(date, prompt, content);
            _entries.Add(entry);
        }
    }
}