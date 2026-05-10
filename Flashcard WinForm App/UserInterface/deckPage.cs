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
        DeckRepo _deckRepo = new DeckRepo();
        User currentUser;

        public deckPage(Deck selectedDeck, User user)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            this.BackColor = Theme.ButtonBgColor;
            currentDeck = selectedDeck;
            currentUser = user;
            refreshData();
        }

        private void refreshData()
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
            var learnCardsPageControl = new global::Flashcard_WinForm_App.UserInterface.learnCardsPage(currentDeck, currentUser);

            Control? parent = this.Parent;
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
            QuizPopUp quizPopUp = new QuizPopUp(currentDeck);
            quizPopUp.ShowDialog();
        }

        private void btnEditCards_Click(object sender, EventArgs e)
        {
            var editCardPageControl = new global::Flashcard_WinForm_App.UserInterface.editCardPage(currentDeck, currentUser);

            Control? parent = this.Parent;
            while (parent != null)
            {
                if (parent is INavigation nav)
                {
                    nav.ShowPage(editCardPageControl);
                    break;
                }
                parent = parent?.Parent;
            }
        }

        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            using (EditDeckPopUp popUp = new EditDeckPopUp(currentDeck))
            {
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    string label = popUp.DeckLabel;
                    string description = popUp.DeckDescription;
                    if (!string.IsNullOrEmpty(label) && !string.IsNullOrEmpty(description))
                    {
                        _deckRepo.UpdateDeck(currentDeck.DeckID, label, description);
                        refreshData();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Control? parent = this.Parent;
                    while (parent != null)
                    {
                        if (parent is homePage nav)
                        {
                            nav.refreshData();
                            break;
                        }
                        parent = parent.Parent;
                    }
                }
            }
        }
    }
}
