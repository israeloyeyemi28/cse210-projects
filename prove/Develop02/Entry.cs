// Represents an individual journal entry with date, prompt, and content
public class Entry
{
    private Date _date;
    private string _prompt;
    private string _content;


    // Constructor to create an entry with date, prompt, and content
    public Entry(Date date, string prompt, string content)
    {
        _date = date;
        _prompt = prompt;
        _content = content;
    }

    // Returns the date of the entry
    public Date GetDate()
    {
        return _date;
    }

    // Returns the prompt associated with the entry
    public string GetPrompt()
    {
        return _prompt;
    }

    // Returns the content of the entry
    public string GetContent()
    {
        return _content;
    }
}

