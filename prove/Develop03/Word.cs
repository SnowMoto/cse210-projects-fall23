using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

public class Word{
    private string _word;
    private bool _isHidden;

    public Word(string word){
        _word = word;
        _isHidden = false;
    }
    public void DisplayWord(){
        if (_isHidden == false){
            Console.Write($"{_word} ");
        }
        else{
            foreach (char letter in _word){
                Console.Write('_');
            }
            Console.Write(' ');
        }
    }   
    public void HideWord(){
        _isHidden = true;
    }

    public bool IsHidden(){
        return _isHidden;
    }
}

