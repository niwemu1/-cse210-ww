using System;


class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture();
        myScripture.GetDisplayText();
        Console.WriteLine(myScripture.GetDisplayText());

        Reference myReference = new Reference();
        myReference.GetDisplayText();
        Console.WriteLine(myReference.GetDisplayText());


    }
}