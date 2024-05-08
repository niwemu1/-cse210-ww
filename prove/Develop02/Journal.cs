using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
      Entry j1 = new Entry();
      j1._date = "11/22/2023";
      j1._promptText = "Software Engineer";
      j1._entryText = "2020";

      Entry j2 = new Entry();
      j2._date = "Microsoft";
      j2._promptText = "Software Engineer";
      j2._entryText = "2020";
      
      List<Entry> entry = new List<Entry>();
       entry.Add(j1);
       entry.Add(j2);
    }

    public void DisplayAll()
    {
      Console.WriteLine($" {_entries}");
    }
    
    public void SaveToFile(string file)
    
    {
      Console.WriteLine("Saving to file");

      string filename = "file.txt";

      using (StreamWriter outputFile = new StreamWriter(filename))
      {
        
         foreach (Entry j in _entries)
         {
           outputFile.WriteLine($"{j._date}");
         }
      }
    }
    public void LoadFromFile(string file)
    {
     
    }

}