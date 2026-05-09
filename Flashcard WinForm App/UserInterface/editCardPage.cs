using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Functions;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class editCardPage : UserControl
    {
        Deck currentDeck;
        List<Flashcard> availableCards;
        private Manager _manager = GlobalData.Manager;
        CardRepo _cardRepo = new CardRepo();
        User currentUser;

        public editCardPage(Deck deck, User user)
        {
            InitializeComponent();
            currentDeck = deck;
            currentUser = user;
            availableCards = _manager.Cards.Where(c => c.DeckID == currentDeck.DeckID).ToList();
            refreshData();
        }

        private void refreshData()
        {
            cardList.DataSource = null;

            var availableCards = _manager.Cards.Where(c => c.DeckID == currentDeck.DeckID).ToList();

            cardList.DataSource = availableCards;
            cardList.DisplayMember = "Definition";
            cardList.ValueMember = "CardID";

            deckLabel.Text = currentDeck.Label;

            int masteryCount = 0;
            int cardCount = 0;
            foreach (var card in availableCards)
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

        private void cardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCard.Enabled = (cardList.SelectedItem != null);
            btnEditCard.Enabled = (cardList.SelectedItem != null);
            if (cardList.SelectedItem is Flashcard selectedCard || availableCards.Count > 0)
            {
                placeholderTextCard.Visible = false;
            }
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            using (AddCardPopUp popUp = new AddCardPopUp(currentUser))
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    string DeckID = currentDeck.DeckID;
                    string definition = popUp.CardDef;
                    string answer = popUp.CardAns;

                    if (!string.IsNullOrEmpty(DeckID) && !string.IsNullOrEmpty(definition) && !string.IsNullOrEmpty(answer))
                    {
                        _cardRepo.AddCard(DeckID, definition, answer);
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            refreshData();
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            var selectedCard = (Flashcard)cardList.SelectedItem;

            if (selectedCard != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete the selected flashcard?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _cardRepo.RemoveCard(selectedCard.CardID);
                    refreshData();
                    MessageBox.Show("Flashcard deleted successfully.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var deckPageControl = new global::Flashcard_WinForm_App.UserInterface.deckPage(currentDeck, currentUser);

            Control parent = this.Parent;
            while (parent != null)
            {
                if (parent is INavigation nav)
                {
                    nav.ShowPage(deckPageControl);
                    break;
                }
                parent = parent.Parent;
            }
        }

        private void btnEditCard_Click(object sender, EventArgs e)
        {
            if (cardList.SelectedItem is Flashcard selectedCard)
            {
                using (EditCardPopUp popUp = new EditCardPopUp(selectedCard))
                {
                    if (popUp.ShowDialog() == DialogResult.OK)
                    {
                        string definition = popUp.CardDef;
                        string answer = popUp.CardAns;
                        if (!string.IsNullOrEmpty(definition) && !string.IsNullOrEmpty(answer))
                        {
                            _cardRepo.UpdateCard(selectedCard.CardID, definition, answer, selectedCard.Mastered);
                            refreshData();
                        }
                        else
                        {
                            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
