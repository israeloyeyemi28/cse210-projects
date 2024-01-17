using System;
using System.Collections.Generic;
using System.IO;



// Represents a date with a method to get a formatted string
public class Date
{
    public string ToShortDateString()
    {
        return DateTime.Now.ToShortDateString();
    }
}






// Main program class
class Program
{
    static void Main()
    {
        // Custom prompts
        List<string> prompts = new List<string>
        {
            "Describe a small act of kindness you witnessed or performed today.",
            "Reflect on a moment that challenged your perspective or changed your mindset.",
            "Share an achievement, no matter how small, that made you proud today.",
            "Explore a goal or aspiration you have for the future and what steps you took today to work towards it.",
        };

        PromptGenerator promptGenerator = new PromptGenerator(prompts);
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");

                    Console.Write("Enter your response: ");
                    string userResponse = Console.ReadLine();

                    Date currentDate = new Date();
                    Entry newEntry = new Entry(currentDate, randomPrompt, userResponse);

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    foreach (Entry entry in journal.GetEntries())
                    {
                        Console.WriteLine($"Date: {entry.GetDate().ToShortDateString()} - Prompt: {entry.GetPrompt()} - Response: {entry.GetContent()}");
                    }
                    break;
                case "3":
                    Console.Write("Enter a filename to save the journal: ");
                    string filenameToSave = Console.ReadLine();
                    journal.SaveToFile(filenameToSave);
                    break;
                case "4":
                    Console.Write("Enter a filename to load the journal from: ");
                    string filenameToLoad = Console.ReadLine();
                    journal.LoadFromFile(filenameToLoad);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
