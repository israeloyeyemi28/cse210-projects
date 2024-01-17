

// Generates prompts and allows retrieving a random prompt
public class PromptGenerator
{
    private List<string> _prompts;

    // Constructor to initialize with a list of prompts
    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    // Generates and returns a random prompt
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
