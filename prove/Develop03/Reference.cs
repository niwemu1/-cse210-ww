using System;

public class Reference
{
    public string Text { get; }

    // Constructor
    public Reference(string text)
    {
        Text = text;
    }

    // Override ToString method to display the reference
    public override string ToString()
    {
        return Text;
    }
}