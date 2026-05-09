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
    public partial class EditCardPopUp : Form
    {
        private Manager _manager = GlobalData.Manager;
        public string CardDef => inputDef.Text;
        public string CardAns => inputAns.Text;
        public EditCardPopUp(Flashcard currentCard)
        {
            InitializeComponent();
            inputAns.Text = currentCard.Answer;
            inputDef.Text = currentCard.Definition;
        }
    }
}
