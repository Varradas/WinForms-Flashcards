using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App
{
    public partial class AddCardPopUp : Form
    {
        private Manager _manager = GlobalData.Manager;
        public string DeckID => deckSelect.SelectedValue.ToString();
        public string CardDef => inputDef.Text;
        public string CardAns => inputAns.Text;

        public AddCardPopUp(User currentUser)
        {
            InitializeComponent();
            var availableDecks = _manager.Decks.Where(d => d.UserID == currentUser.UserID).ToList();
            deckSelect.DataSource = availableDecks;
            deckSelect.DisplayMember = "Label";
            deckSelect.ValueMember = "DeckID";
        }
    }
}
