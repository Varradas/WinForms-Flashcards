using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class Deck
    {
        public int DeckID { get; set; }
        public int UserID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
