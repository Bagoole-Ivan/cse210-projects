using System;
using System.ComponentModel;

class Scriptures
{
    public class Entry {
        public string _text = "";
        public string Reference = "";

        public void Format ()
        {
            Console.WriteLine($"text: {_text}, Reference: {Reference} " );
        }
    }
}