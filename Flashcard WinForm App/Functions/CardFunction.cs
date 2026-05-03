using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    internal class CardFunction
    {
        public Flashcard GetFlashcard(int cardId, List<Flashcard> cards)
        {
            var chosenCard = cards.Find(c => c.CardID == cardId);
            if (chosenCard != null)
            {
                return chosenCard;
            }
            else
            {
                throw new Exception("Card not found.");
            }
        }
    }
}
