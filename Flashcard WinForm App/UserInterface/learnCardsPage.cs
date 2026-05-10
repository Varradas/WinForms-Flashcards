using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Functions;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class learnCardsPage : UserControl
    {
        Deck currentDeck;
        int currentCardIndex = 0;
        int targetLeft = 47;
        bool isFlipped = false;
        bool showingDefinition = true;
        List<Flashcard> availableCards;
        private Manager _manager = GlobalData.Manager;
        User currentUser;

        public learnCardsPage(Deck deck, User user)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            this.BackColor = Theme.ButtonBgColor;
            currentDeck = deck;
            currentUser = user;
            availableCards = _manager.Cards.Where(c => c.DeckID == currentDeck.DeckID).ToList();
            refreshData();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (isFlipped)
            {
                timer2.Start();
            }
            if (!isFlipped)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (showingDefinition)
            {
                cardOuter.Height -= 20;
                if (cardOuter.Height <= 0)
                {
                    cardOuter.Height = 0;
                    showingDefinition = false;
                    cardLabel.Text = availableCards[currentCardIndex].Answer;
                    cardOuter.BackColor = Theme.CardBack;
                }
            }
            else
            {
                cardOuter.Height += 20;
                if (cardOuter.Height >= 206)
                {
                    cardOuter.Height = 206;
                    isFlipped = true;
                    showingDefinition = true;
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (showingDefinition)
            {
                cardOuter.Height -= 20;
                if (cardOuter.Height <= 0)
                {
                    cardOuter.Height = 0;
                    showingDefinition = false;
                    cardLabel.Text = availableCards[currentCardIndex].Definition;
                    cardOuter.BackColor = Theme.CardFront;
                }
            }
            else
            {
                cardOuter.Height += 20;
                if (cardOuter.Height >= 206)
                {
                    cardOuter.Height = 206;
                    isFlipped = false;
                    showingDefinition = true;
                    timer2.Stop();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                _manager.UpdateMastery(availableCards[currentCardIndex].CardID, true);
            }
            else
            {
                _manager.UpdateMastery(availableCards[currentCardIndex].CardID, false);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentCardIndex < availableCards.Count - 1)
            {
                currentCardIndex++;
                refreshData();

                cardOuter.Left = this.Width;
                timer3.Start();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentCardIndex > 0)
            {
                currentCardIndex--;
                refreshData();

                cardOuter.Left = -cardOuter.Width;
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int distanceToMove = (targetLeft - cardOuter.Left);

            if (Math.Abs(distanceToMove) > 1)
            {
                cardOuter.Left += distanceToMove / 5;
            }
            else
            {
                cardOuter.Left = targetLeft;
                timer3.Stop();
            }
        }

        private void refreshData()
        {
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;

            if (availableCards.Count > 0)
            {
                cardLabel.Text = availableCards[currentCardIndex].Definition;
                checkBox1.Checked = availableCards[currentCardIndex].Mastered;
                cardOuter.BackColor = Theme.CardFront;
                btnFlip.Enabled = true;
                isFlipped = false;
                showingDefinition = true;
            }
            else
            {
                cardLabel.Text = "No cards in this deck!";
                checkBox1.Visible = false;
                btnFlip.Enabled = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                return;
            }

            if (availableCards[currentCardIndex] == availableCards[0])
            {
                btnPrevious.Enabled = false;
            }
            if (availableCards[currentCardIndex] == availableCards[availableCards.Count - 1])
            {
                btnNext.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var deckPageControl = new global::Flashcard_WinForm_App.UserInterface.deckPage(currentDeck, currentUser);

            Control? parent = this.Parent;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 1. Handle Ctrl + S
            if (keyData == (Keys.Left))
            {
                btnPrevious.PerformClick();
                return true; // "True" tells Windows we handled the key (prevents 'ding' sound)
            }

            // 2. Handle a simple key like F5
            if (keyData == Keys.Right)
            {
                btnNext.PerformClick();
                return true;
            }

            if (keyData == Keys.Space)
            {
                btnFlip.PerformClick();
                return true;
            }

            if (keyData == Keys.Enter)
            {
                checkBox1.Checked = !checkBox1.Checked;
                return true;
            }   

            // 3. IMPORTANT: Call the base method so other keys (like Tab) still work!
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
