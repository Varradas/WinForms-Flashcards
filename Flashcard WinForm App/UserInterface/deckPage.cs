using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Functions;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class deckPage : UserControl
    {
        Deck currentDeck;
        private Manager _manager = GlobalData.Manager;
        CardRepo cardRepo = new CardRepo();

        public deckPage(Deck selectedDeck)
        {
            InitializeComponent();
            currentDeck = selectedDeck;
            RefreshContent();
        }

        private void RefreshContent()
        {
            deckLabel.Text = currentDeck.Label;
            deckDescription.Text = currentDeck.Description;

            var cards = _manager.Cards.Where(c => c.DeckID == currentDeck.DeckID).ToList();
            int masteryCount = 0;
            int cardCount = 0;
            foreach (var card in cards)
            {
                if (card.Mastered == true)
                {
                    masteryCount++;
                }
                cardCount++;
            }
            double masteryPercentage = cardCount > 0 ? (double)masteryCount / cardCount * 100 : 0;
            masteryLabel.Text = "Mastery: " + masteryPercentage.ToString("F2") + "%";
        }

        private void btnLearnCards_Click(object sender, EventArgs e)
        {
            var learnCardsPageControl = new global::Flashcard_WinForm_App.UserInterface.learnCardsPage(currentDeck);

            Control parent = this.Parent;
            while (parent != null)
            {
                if (parent is INavigation nav)
                {
                    nav.ShowPage(learnCardsPageControl);
                    break;
                }
                parent = parent.Parent;
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCards_Click(object sender, EventArgs e)
        {

        }
    }
}
