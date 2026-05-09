namespace Flashcard_WinForm_App.UserInterface
{
    partial class deckPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deckLabel = new Label();
            deckDescription = new Label();
            masteryLabel = new Label();
            btnLearnCards = new Button();
            btnStartQuiz = new Button();
            btnEditCards = new Button();
            label1 = new Label();
            btnEditDeck = new Button();
            SuspendLayout();
            // 
            // deckLabel
            // 
            deckLabel.AutoSize = true;
            deckLabel.Font = new Font("Segoe UI", 18F);
            deckLabel.Location = new Point(28, 31);
            deckLabel.Name = "deckLabel";
            deckLabel.Size = new Size(115, 32);
            deckLabel.TabIndex = 0;
            deckLabel.Text = "decklabel";
            // 
            // deckDescription
            // 
            deckDescription.Font = new Font("Segoe UI", 12F);
            deckDescription.Location = new Point(28, 96);
            deckDescription.Name = "deckDescription";
            deckDescription.Size = new Size(390, 257);
            deckDescription.TabIndex = 1;
            deckDescription.Text = "deckDescription";
            // 
            // masteryLabel
            // 
            masteryLabel.AutoSize = true;
            masteryLabel.Location = new Point(39, 65);
            masteryLabel.Name = "masteryLabel";
            masteryLabel.Size = new Size(74, 15);
            masteryLabel.TabIndex = 2;
            masteryLabel.Text = "masterylabel";
            // 
            // btnLearnCards
            // 
            btnLearnCards.Location = new Point(28, 385);
            btnLearnCards.Name = "btnLearnCards";
            btnLearnCards.Size = new Size(105, 23);
            btnLearnCards.TabIndex = 3;
            btnLearnCards.Text = "Learn Flashcards";
            btnLearnCards.UseVisualStyleBackColor = true;
            btnLearnCards.Click += btnLearnCards_Click;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new Point(139, 385);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(99, 23);
            btnStartQuiz.TabIndex = 4;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // btnEditCards
            // 
            btnEditCards.Location = new Point(244, 385);
            btnEditCards.Name = "btnEditCards";
            btnEditCards.Size = new Size(105, 23);
            btnEditCards.TabIndex = 5;
            btnEditCards.Text = "Edit Flashcards";
            btnEditCards.UseVisualStyleBackColor = true;
            btnEditCards.Click += btnEditCards_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-23, 87);
            label1.Name = "label1";
            label1.Size = new Size(485, 2);
            label1.TabIndex = 6;
            // 
            // btnEditDeck
            // 
            btnEditDeck.Location = new Point(28, 356);
            btnEditDeck.Name = "btnEditDeck";
            btnEditDeck.Size = new Size(132, 23);
            btnEditDeck.TabIndex = 7;
            btnEditDeck.Text = "Edit Deck Information";
            btnEditDeck.UseVisualStyleBackColor = true;
            btnEditDeck.Click += btnEditDeck_Click;
            // 
            // deckPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditDeck);
            Controls.Add(label1);
            Controls.Add(btnEditCards);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnLearnCards);
            Controls.Add(masteryLabel);
            Controls.Add(deckDescription);
            Controls.Add(deckLabel);
            Name = "deckPage";
            Size = new Size(448, 439);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deckLabel;
        private Label deckDescription;
        private Label masteryLabel;
        private Button btnLearnCards;
        private Button btnStartQuiz;
        private Button btnEditCards;
        private Label label1;
        private Button btnEditDeck;
    }
}
