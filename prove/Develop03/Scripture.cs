using System;
using System.Collections.Generic;

public class Scripture 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text) 
    {
        _reference = Reference;
        
        string[] splitText = text.Split(' ');

        foreach (string word in splitText)
        {
            Word phrase = new Word(word);

            _words.Add(phrase);
        }
    }

    public void HideRandomWords() 
    {
        bool test;
        
        do {
                   
        Random rnd = new Random();
        int number = rnd.Next(0, _words.Count());

        test = _words[number].IsHidden();
        _words[number].Hide();

        } while (test == true); 
    }

    public string GetDisplayText()
    {
        List<string> str = new List<string>();

        foreach (Word wordn in _words) 
        
        {
            string a = wordn.GetDisplayText();
            str.Add(a); 
        }

        string fullText = String.Join(' ', str);

        return fullText;

    }

    public bool IsCompletelyHidden()
    {
        bool fullHidden = true;

         foreach (Word word in _words)
            {
                fullHidden = word.IsHidden();

                if (fullHidden == false) 
                {
                    break;
                }
            }
        return fullHidden;   
    }

    public Reference GetReference()
    {
        return _reference;
    }
}