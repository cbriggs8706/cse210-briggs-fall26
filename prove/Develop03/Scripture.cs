using System;
public class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  private Random _random = new Random();

  public Scripture(Reference reference, string text)
  {
    _reference = reference;
    _words = new List<Word>();
    
    string[] words = text.Split(' ');
    foreach (string word in words)
    {
      _words.Add(new Word(word));
    }
  }
    public void HideRandomWords(int numberToHide)
    {
      List<Word> visibleWords = new List<Word>();
      foreach (Word word in _words)
      {
        if (!word.IsHidden())
        {
          visibleWords.Add(word);
        }
      }
    
      for (int i = 0; i < numberToHide; i++)
      {
        if (visibleWords.Count == 0)
        {
          break;
        }

        int index = _random.Next(visibleWords.Count);
        visibleWords[index].Hide();
        visibleWords.RemoveAt(index);
      }
  }

  public bool IsCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      if (!word.IsHidden())
      {
        return false;
      }
      
    }
    return true;
  }

  public string GetDisplayText()
  {
    string text = _reference.GetDisplayText() + "\n";

    foreach (Word word in _words)
    {
      text += word.GetDisplayText() + " ";

    }
    return text.TrimEnd();
  }


}