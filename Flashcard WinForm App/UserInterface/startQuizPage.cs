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
    public partial class startQuizPage : UserControl
    {
        QuizSession session;
        string quizType;
        List<RadioButton> radioButtons;
        List<Label> radioLabels;
        public startQuizPage(QuizSession quiz, string quizType)
        {
            InitializeComponent();
            session = quiz;
            this.quizType = quizType;

            radioButtons = new List<RadioButton> { rbOp1, rbOp2, rbOp3, rbOp4 };
            radioLabels = new List<Label> { radioLabel1, radioLabel2, radioLabel3, radioLabel4 };
        }

        private void startQuizPage_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(800, 600);
                nav.LockSize(true);
            }
            LoadNextCard();
        }

        private void LoadNextCard()
        {
            var card = session.GetCurrentCard();
            if (card == null) return;

            lblQuestion.Text = card.Definition;
            inputAnswer.Clear();

            if (quizType == "Identification")
            {
                inputAnswer.Visible = true;
                pnlMultipleChoice.Visible = false;
                btnSubmit.Left = 334;
                btnSubmit.Top = 351;
            }
            else if (quizType == "Multiple Choice")
            {
                inputAnswer.Visible = false;
                pnlMultipleChoice.Visible = true;
                btnSubmit.Left = 334;
                btnSubmit.Top = 400;

                var options = session.GetMultipleChoiceOptions();
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    if (i < options.Count)
                    {
                        radioButtons[i].Visible = true;
                        radioButtons[i].Text = null;
                        radioLabels[i].Text = options[i];
                        radioButtons[i].Checked = false; 
                    }
                    else
                    {
                        radioButtons[i].Visible = false; 
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var currentCard = session.GetCurrentCard();
            bool isCorrect = false;

            if (quizType == "Identification")
            {
                isCorrect = string.Equals(inputAnswer.Text.Trim(), currentCard.Answer, StringComparison.OrdinalIgnoreCase);
            }
            else if (quizType == "Multiple Choice")
            {
                for (int i = 0; i < radioButtons.Count; i++)
                {
                    if (radioButtons[i].Visible)
                    {
                        radioButtons[i].Text = radioLabels[i].Text;
                    }
                }
                    var selectedRb = radioButtons.FirstOrDefault(rb => rb.Checked);
                if (selectedRb == null)
                {
                    MessageBox.Show("Please select an answer first.");
                    return;
                }
                isCorrect = (selectedRb.Text == currentCard.Answer);
            }

            if (isCorrect)
            {
                session.MarkCorrect();
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show($"Incorrect. The right answer was: {currentCard.Answer}");
            }

            if (session.NextCard())
            {
                LoadNextCard();
            }
            else
            {
                MessageBox.Show($"Quiz Complete! Your score: {session.score} / {session.TotalCards()}", "Confirmation", MessageBoxButtons.OK);
                this.FindForm()?.Close();
            }
        }
    }
}
