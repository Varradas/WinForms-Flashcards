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
    public partial class homePage : UserControl, INavigation
    {
        User currentUser;
        private Manager _manager = GlobalData.Manager;
        DeckRepo deckRepo = new DeckRepo();

        public homePage(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(800, 600);
            }

            refreshData();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginPageControl = new global::Flashcard_WinForm_App.UserInterface.loginPage();

            Form? parent = this.ParentForm;
            if (parent is INavigation nav)
            {
                nav.ShowPage(loginPageControl);
            }
        }

        private void refreshData()
        {
            deckList.DataSource = null;

            var availableDecks = _manager.Decks.Where(d => d.UserID == currentUser.UserID).ToList();

            deckList.DataSource = availableDecks;
            deckList.DisplayMember = "Label";
            deckList.ValueMember = "DeckID";

            if (availableDecks.Count > 0)
            {
                placeholderTextDeck.Visible = false;

            }
            else
            {
                placeholderTextDeck.Visible = true;
            }
        }

        private void deckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteDeck.Enabled = (deckList.SelectedItem != null);
            if (deckList.SelectedItem is Deck selectedDeck)
            {
                placeholderTextDisplay.Visible = false;
                var details = new deckPage(selectedDeck);
                this.ShowPage(details);
            }
        }

        public void ShowPage(UserControl page)
        {
            foreach (Control ctrl in pnlContentSide.Controls)
            {
                ctrl.Dispose(); 
            }
            pnlContentSide.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContentSide.Controls.Add(page);
        }

        public void ResizeHost(int width, int height)
        {
            
        }

        public void LockSize(bool lockSize)
        {
            
        }
    }
}
