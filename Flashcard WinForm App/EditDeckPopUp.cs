using Flashcard_WinForm_App.Functions;
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
    public partial class EditDeckPopUp : BaseForm
    {
        public string DeckLabel => inputLabel.Text;
        public string DeckDescription => inputDescription.Text;
        public EditDeckPopUp(Deck deck)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            inputLabel.Text = deck.Label;
            inputDescription.Text = deck.Description;
        }
    }
}
