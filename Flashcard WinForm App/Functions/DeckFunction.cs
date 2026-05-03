using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    internal class DeckFunction
    {
        public Deck GetDeck(int deckId, List<Deck> decks)
        {
            var chosenDeck = decks.Find(d => d.DeckID == deckId);
            if (chosenDeck != null)
            {
                return chosenDeck;
            }
            else
            {
                throw new Exception("Deck not found.");
            }
        }
    }
}
