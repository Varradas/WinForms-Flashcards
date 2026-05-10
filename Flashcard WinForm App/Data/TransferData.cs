using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Data
{
    public class TransferData
    {
        public class DeckExportPackage
        {
            public required string Label { get; set; }
            public required string Description { get; set; }
            public required List<FlashcardData> Cards { get; set; }
        }

        public class FlashcardData
        {
            public required string Definition { get; set; }
            public required string Answer { get; set; }
        }
    }
}
