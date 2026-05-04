using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class Deck
    {
        public string DeckID { get; set; } = Guid.NewGuid().ToString();
        public string UserID { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
