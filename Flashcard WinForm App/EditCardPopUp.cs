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

namespace Flashcard_WinForm_App
{
    public partial class EditCardPopUp : BaseForm
    {
        private Manager _manager = GlobalData.Manager;
        public string CardDef => inputDef.Text;
        public string CardAns => inputAns.Text;
        public EditCardPopUp(Flashcard currentCard)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            inputAns.Text = currentCard.Answer;
            inputDef.Text = currentCard.Definition;
        }
    }
}
