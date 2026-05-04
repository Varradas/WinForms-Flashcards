using Flashcard_WinForm_App.Functions;
using Flashcard_WinForm_App.Models;
using Flashcard_WinForm_App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class dashboard : UserControl
    {
        User currentUser;
        private Manager _manager = GlobalData.Manager;
        DeckRepo deckRepo = new DeckRepo();
        CardRepo cardRepo = new CardRepo();

        public dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;

            refreshData();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(800, 600);
            }

            displayNickname.Text = $"Welcome, {currentUser.Nickname}!";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var loginPageControl = new global::Flashcard_WinForm_App.UserInterface.loginPage();

            Form parent = this.ParentForm;
            if (parent is INavigation nav)
            {
                nav.ShowPage(loginPageControl);
            }
        }

        private void addDeckBtn_Click(object sender, EventArgs e)
        {
            using (AddDeckPopUp popUp = new AddDeckPopUp())
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    string label = popUp.DeckLabel;
                    string description = popUp.DeckDescription;

                    deckRepo.AddDeck(currentUser.UserID, label, description);
                }
            }
            refreshData();
        }

        private void addCardBtn_Click(object sender, EventArgs e)
        {
            using (AddCardPopUp popUp = new AddCardPopUp(currentUser))
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    string DeckID = popUp.DeckID;
                    string definition = popUp.CardDef;
                    string answer = popUp.CardAns;


                    cardRepo.AddCard(DeckID, definition, answer);
                }
            }
            refreshData();
        }

        private void deleteDeckBtn_Click(object sender, EventArgs e)
        {
            var selectedDeck = (Deck)deckList.SelectedItem;

            if (selectedDeck != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete the deck: {selectedDeck.Label}?\nThis will also delete all associated cards!",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    deckRepo.RemoveDeck(selectedDeck.DeckID);
                    refreshData();

                    MessageBox.Show("Deck deleted successfully.");
                }
            }
        }

        private void deleteCardBtn_Click(object sender, EventArgs e)
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
                    cardRepo.RemoveCard(selectedCard.CardID);

                    // Refresh your UI lists
                    refreshData();

                    MessageBox.Show("Flashcard deleted successfully.");
                }
                // If they clicked 'No', nothing happens and the box just closes.
            }
        }

        private void deckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteDeckBtn.Enabled = (deckList.SelectedItem != null);
        }

        private void cardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteCardBtn.Enabled = (cardList.SelectedItem != null);
        }

        private void refreshData()
        {
            deckList.DataSource = null;
            cardList.DataSource = null;

            var availableDecks = _manager.Decks.Where(d => d.UserID == currentUser.UserID).ToList();
            var availableCards = _manager.Cards.Where(c => availableDecks.Any(d => d.DeckID == c.DeckID)).ToList();

            deckList.DataSource = availableDecks;
            cardList.DataSource = availableCards;
            deckList.DisplayMember = "Label";
            cardList.DisplayMember = "Definition";
            deckList.ValueMember = "DeckID";
            cardList.ValueMember = "CardID";

        }
    }
}
