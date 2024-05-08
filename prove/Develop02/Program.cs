using System;

class Program
{

  static void Main(string[] args)
  {
    Entry j1 = new Entry();
      j1._date = "Microsoft";
      j1._promptText = "Software Engineer";
      j1._entryText = "2020";
      

    Entry j2 = new Entry();
      j2._date = "Microsoft";
      j2._promptText = "Software Engineer";
      j2._entryText = "2020";

    List<Entry> _entries = new List<Entry>();
      _entries.Add(j1);
      _entries.Add(j2);

    foreach (Entry j in _entries) 
    {
        Console.WriteLine(j2._date);
    } 

  }  
 

}