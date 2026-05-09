using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Data
{
    public class TransferData
    {
        public class DeckExportPackage
        {
            public string Label { get; set; }
            public string Description { get; set; }
            public List<FlashcardData> Cards { get; set; }
        }

        public class FlashcardData
        {
            public string Definition { get; set; }
            public string Answer { get; set; }
        }
    }
}
