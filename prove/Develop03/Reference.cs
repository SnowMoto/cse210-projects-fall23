using System;

//create class with variables.
public class Reference{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    public Reference(string inputBook){
        _book = inputBook;
        _chapter = "1";
        _verseStart = "1";
        _verseEnd = "0";
    }

    //create user input with only does the first 2 parameters.
    public Reference(string inputBook, string inputChapter){
        _book = inputBook;
        _chapter = inputChapter;
        _verseStart = "1";
        _verseEnd = "0";
    }

    //create user input with only does the first three parameters.
    public Reference(string inputBook, string inputChapter, string inputStart){
        _book = inputBook;
        _chapter = inputChapter;
        _verseStart = inputStart;
        _verseEnd = "0";
    }

    //create user input all parameters.
    public Reference(string inputBook,string inputChapter,string inputStart,string inputEnd){
        _book = inputBook;
        _chapter = inputChapter;
        _verseStart = inputStart;
        _verseEnd = inputEnd;
    }

    //Constructors with Get and Set
    public string GetBook(){
        return _book;
    }

    public void DisplayReference(){

        if (_verseEnd == "0"){
            Console.WriteLine($"{_book}: {_chapter}: {_verseStart}");
        }
        else {
            Console.WriteLine($"{_book}: {_chapter}: {_verseStart}-{_verseEnd}");
        }
        
    }

}

