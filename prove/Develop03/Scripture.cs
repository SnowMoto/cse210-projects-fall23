using System;
using System.IO;

public class Scripture{
    private Reference _references;
    private List<Word> _words = new List<Word>();
    // private bool _allHidden;

    public Scripture(Reference references, string text) {
        string[]words = text.Split(" ");
        _references = references;

        foreach (string singleWord in words) {
            Word word = new Word(singleWord);
            _words.Add(word);
        }
    }

    public void GetRenderedText() {

        _references.DisplayReference();

        foreach (Word word in _words){
            word.DisplayWord();
        }
    }

    public bool AllHidden(){
        bool allHidden = true; // So far, everyone says they are hidden - initial condition
        foreach (Word word in _words){   // Looping conditions
            // What we do every iteration
            allHidden = allHidden && word.IsHidden(); // True or False
        }
        // What we do when the loop is over
        return allHidden;
    }

    /*public bool AllHidden(){
        foreach (Word word in _words){
            if (!word.IsHidden())
                return false;
        }
        return true;
    }*/

    public bool HideWords() {
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_words.Count);
        while (_words[index].IsHidden()) {
            index = randomGenerator.Next(_words.Count);
        }
        _words[index].HideWord();
        return AllHidden();
    }

}