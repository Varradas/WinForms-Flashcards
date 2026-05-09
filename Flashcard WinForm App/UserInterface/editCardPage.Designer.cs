namespace Flashcard_WinForm_App.UserInterface
{
    partial class editCardPage
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
            label1 = new Label();
            masteryLabel = new Label();
            deckLabel = new Label();
            btnDeleteCard = new Button();
            btnEditCard = new Button();
            btnAddCard = new Button();
            btnBack = new Button();
            cardList = new ListBox();
            label2 = new Label();
            placeholderTextCard = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-23, 87);
            label1.Name = "label1";
            label1.Size = new Size(485, 2);
            label1.TabIndex = 9;
            // 
            // masteryLabel
            // 
            masteryLabel.AutoSize = true;
            masteryLabel.Location = new Point(39, 65);
            masteryLabel.Name = "masteryLabel";
            masteryLabel.Size = new Size(74, 15);
            masteryLabel.TabIndex = 8;
            masteryLabel.Text = "masterylabel";
            // 
            // deckLabel
            // 
            deckLabel.AutoSize = true;
            deckLabel.Font = new Font("Segoe UI", 18F);
            deckLabel.Location = new Point(28, 31);
            deckLabel.Name = "deckLabel";
            deckLabel.Size = new Size(115, 32);
            deckLabel.TabIndex = 7;
            deckLabel.Text = "decklabel";
            // 
            // btnDeleteCard
            // 
            btnDeleteCard.Enabled = false;
            btnDeleteCard.Location = new Point(262, 349);
            btnDeleteCard.Name = "btnDeleteCard";
            btnDeleteCard.Size = new Size(105, 23);
            btnDeleteCard.TabIndex = 12;
            btnDeleteCard.Text = "Delete Flashcard";
            btnDeleteCard.UseVisualStyleBackColor = true;
            btnDeleteCard.Click += btnDeleteCard_Click;
            // 
            // btnEditCard
            // 
            btnEditCard.Enabled = false;
            btnEditCard.Location = new Point(157, 349);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(99, 23);
            btnEditCard.TabIndex = 11;
            btnEditCard.Text = "Edit Flashcard";
            btnEditCard.UseVisualStyleBackColor = true;
            btnEditCard.Click += btnEditCard_Click;
            // 
            // btnAddCard
            // 
            btnAddCard.Location = new Point(46, 349);
            btnAddCard.Name = "btnAddCard";
            btnAddCard.Size = new Size(105, 23);
            btnAddCard.TabIndex = 10;
            btnAddCard.Text = "New Flashcard";
            btnAddCard.UseVisualStyleBackColor = true;
            btnAddCard.Click += btnAddCard_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cardList
            // 
            cardList.FormattingEnabled = true;
            cardList.Location = new Point(46, 118);
            cardList.Name = "cardList";
            cardList.Size = new Size(360, 214);
            cardList.TabIndex = 15;
            cardList.SelectedIndexChanged += cardList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 94);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 16;
            label2.Text = "Available Flashcards";
            // 
            // placeholderTextCard
            // 
            placeholderTextCard.AutoSize = true;
            placeholderTextCard.BackColor = Color.White;
            placeholderTextCard.Location = new Point(169, 212);
            placeholderTextCard.Name = "placeholderTextCard";
            placeholderTextCard.Size = new Size(110, 15);
            placeholderTextCard.TabIndex = 17;
            placeholderTextCard.Text = "No Cards Available.";
            // 
            // editCardPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(placeholderTextCard);
            Controls.Add(label2);
            Controls.Add(cardList);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteCard);
            Controls.Add(btnEditCard);
            Controls.Add(btnAddCard);
            Controls.Add(label1);
            Controls.Add(masteryLabel);
            Controls.Add(deckLabel);
            Name = "editCardPage";
            Size = new Size(448, 439);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label masteryLabel;
        private Label deckLabel;
        private Button btnDeleteCard;
        private Button btnEditCard;
        private Button btnAddCard;
        private Button btnBack;
        private ListBox cardList;
        private Label label2;
        private Label placeholderTextCard;
    }
}
