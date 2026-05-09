using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    public class QuizSession
    {
        Manager _manager = GlobalData.Manager;
        private int currentIndex = 0;
        public int score { get; set; }
        List<Flashcard> availableCards = new List<Flashcard>();
        IEnumerable<Flashcard> filteredCards = new List<Flashcard>();

        public QuizSession(Deck currentDeck, bool excludeMastered, int? maxItems)
        {
            availableCards = _manager.Cards.Where(c => c.DeckID == currentDeck.DeckID).ToList();
            if (excludeMastered )
            {
                filteredCards = availableCards.Where(c => c.Mastered == false);
                availableCards = filteredCards.ToList();
            }

            Random rng = new Random();
            availableCards = availableCards.OrderBy(x => rng.Next()).ToList();

            if (maxItems.HasValue && maxItems.Value < availableCards.Count)
            {
                availableCards = availableCards.Take(maxItems.Value).ToList();
            }
        }

        public Flashcard GetCurrentCard() => availableCards.Count > 0 ? availableCards[currentIndex] : null;

        public bool NextCard()
        {
            if (currentIndex < availableCards.Count - 1)
            {
                currentIndex++;
                return true;
            }
            return false; 
        }

        public void MarkCorrect() => score++;

        public int TotalCards() => availableCards.Count;

        public List<string> GetMultipleChoiceOptions()
        {
            var currentCard = GetCurrentCard();
            if (currentCard == null) return new List<string>();

            var options = _manager.Cards
                .Where(c => c.CardID != currentCard.CardID && !string.IsNullOrWhiteSpace(c.Answer))
                .OrderBy(x => Guid.NewGuid()) 
                .Take(3)
                .Select(c => c.Answer)
                .ToList();

            options.Add(currentCard.Answer);

            return options.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
