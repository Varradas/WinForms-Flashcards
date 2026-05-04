using Flashcard_WinForm_App.Models;
using Flashcard_WinForm_App.Data;
using System.Collections.Generic;
using System.Linq;

namespace Flashcard_WinForm_App.Functions
{
    public class DeckRepo
    {
        public List<Deck> GetDecksForUser(string userId)
        {
            return GlobalData.Manager.Decks
                .Where(d => d.UserID == userId)
                .ToList();
        }

        public void AddDeck(string userId, string label, string description)
        {
            GlobalData.Manager.CreateDeck(userId, label, description);
        }

        public void UpdateDeck(string deckId, string label, string description)
        {
            GlobalData.Manager.UpdateDeck(deckId, label, description);
        }

        public void RemoveDeck(string deckId)
        {
            GlobalData.Manager.DeleteDeck(deckId);
        }
    }
}