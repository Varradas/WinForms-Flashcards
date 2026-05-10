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
    public partial class QuizPopUp : BaseForm, INavigation
    {
        Deck currentDeck;
        public QuizPopUp(Deck deck)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            currentDeck = deck;
        }

        private void txtItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItems.Text) || choiceQuizType?.SelectedItem == null)
            {
                MessageBox.Show("Please enter the number of items and select a quiz type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var quizSession = new QuizSession(
                currentDeck, 
                masteredFilter.Checked, 
                int.Parse(txtItems.Text));

            // Ensure a non-null string is passed to the startQuizPage constructor to satisfy nullability.
            string quizType = choiceQuizType?.SelectedItem?.ToString() ?? string.Empty;

            var startQuizPageControl = new global::Flashcard_WinForm_App.UserInterface.startQuizPage(quizSession, quizType);

            ShowPage(startQuizPageControl);
            
        }

        public void ShowPage(UserControl page)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        public void ResizeHost(int width, int height)
        {
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }

        public void LockSize(bool lockSize)
        {
            if (lockSize)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
            }
        }
    }
}
