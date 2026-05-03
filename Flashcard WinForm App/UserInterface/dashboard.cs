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
    public partial class dashboard : UserControl
    {
        User currentUser;
        DeckRepo deckRepo = new DeckRepo();
        CardRepo cardRepo = new CardRepo();

        public dashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            List<Deck> availableDecks = deckRepo.GetDecksForUser(currentUser.UserID);
            List<Flashcard> availableCards = cardRepo.GetFlashcardsDB(availableDecks);
            deckList.DataSource = availableDecks;
            deckList.DisplayMember = "Label";
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
    }
}
