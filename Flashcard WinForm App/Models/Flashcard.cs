using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class Flashcard
    {
        public string CardID { get; set; } = Guid.NewGuid().ToString();
        public string DeckID { get; set; } = null!;
        public string Definition { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public bool Mastered { get; set; }
    }
}
