using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App
{
    public partial class AddDeckPopUp : Form
    {
        public string DeckLabel => inputLabel.Text;
        public string DeckDescription => inputDescription.Text;

        public AddDeckPopUp()
        {
            InitializeComponent();
        }
    }
}
