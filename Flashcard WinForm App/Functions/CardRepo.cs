using Flashcard_WinForm_App.Models;
using Flashcard_WinForm_App.Data;
using System.Collections.Generic;
using System.Linq;

namespace Flashcard_WinForm_App.Functions
{
    public class CardRepo
    {
        public List<Flashcard> GetFlashcardsForDeck(string deckId)
        {
            return GlobalData.Manager.Cards
                .Where(c => c.DeckID == deckId)
                .ToList();
        }

        public void AddCard(string deckId, string definition, string answer)
        {
            GlobalData.Manager.CreateCard(deckId, definition, answer);
        }

        public void UpdateCard(string cardId, string definition, string answer, bool mastered)
        {
            GlobalData.Manager.UpdateCard(cardId, definition, answer, mastered);
        }

        public void RemoveCard(string cardId)
        {
            GlobalData.Manager.DeleteCard(cardId);
        }
    }
}