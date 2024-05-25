using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
    _text = text;
    
    }

    public void Hide()
    {
     Console.WriteLine("Come, let us sing for joy to the LORD; let us shout aloud to the Rock of our salvation. Let us come before him with thanksgiving and extol him with music and song. For the LORD is the great God, the great King above all gods.");    
    }
    public void Show()
    { 
     Console.WriteLine("Press enter to continue or quit to finish"); 
    }

    public bool IsHidden()
    {
     return false;
    }

    public string GetDisplayText()
    {
     string text = $"{_text}, {_isHidden}";
      return text;
    }

}


