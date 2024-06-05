using System;
using System.Collections.Generic;
using System.IO;
class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        Entry entry = new Entry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}");
                writer.WriteLine($"Question: {entry.Prompt}");
                writer.WriteLine($"Response: {entry.Response}\n");
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i += 4)
        {
            string date = lines[i].Split(": ")[1];
            string prompt = lines[i + 1].Split(": ")[1];
            string response = lines[i + 2].Split(": ")[1];
            AddEntry(prompt, response, date);
        }
    }

    //Exceeding requirements2 Add a method to retrieve a random writing prompt
    public string GetRandomWritingPrompt()
    {
        string[] writingPrompts = {
            "Describe a moment that made you smile today.",
            "What are three things you are grateful for right now?",
            "Write about a challenge you overcame recently.",
            "Describe a goal you want to achieve and why it's important to you.",
            "Reflect on a lesson you learned recently.",
            "Think of anything you might want to share with someone."
            
        };

        Random rand = new Random();
        return writingPrompts[rand.Next(writingPrompts.Length)];
    }
}