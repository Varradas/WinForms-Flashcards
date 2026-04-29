using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class Flashcard
    {
        public int CardID { get; set; }
        public int DeckID { get; set; }
        public string Definition { get; set; }
        public string Answer { get; set; }
        public bool Mastered { get; set; }
    }
}
