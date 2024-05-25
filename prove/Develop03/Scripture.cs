
using System;
using System.Net.Quic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _word;

   

    public Scripture(Reference Reference, string text)
    {
      _reference = Reference;
      
    }

    public void HideRandomWords(int numberToHide)
    {
      Console.WriteLine("Psalms 95:1-3 Come, let us sing for joy to the LORD; let us shout aloud to the Rock of our salvation. Let us come before him with thanksgiving and extol him with music and song. For the LORD is the great God, the great King above all gods.");    
    }

    public string GetDisplayText()
    {
      string text = $"{_reference}, {_word}";
      return text;
      
    }

    public bool IsCompletelyHidden()
    {
      return false;
        
    }
}