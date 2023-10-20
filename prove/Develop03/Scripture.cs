using System;
using System.IO;

public class Scripture{
    private Reference _references;
    private List<Word> _words = new List<Word>();
    private bool _allHidden;
public Scripture(Reference references, string text){
    string[]words = text.Split(" ");
     _references = references;

    foreach (string singleWord in words){
        Word word = new Word(singleWord);
        _words.Add(word);
        }
    }
public void GetRenderedText(){

    _references.DisplayReference();

    foreach (Word word in _words){
        word.DisplayWord();
    }
}

public void AllHidden(){
    

}
}