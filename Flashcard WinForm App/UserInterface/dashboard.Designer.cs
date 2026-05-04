namespace Flashcard_WinForm_App.UserInterface
{
    partial class dashboard
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
            displayNickname = new Label();
            btnLogOut = new Button();
            deckList = new ListBox();
            cardList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            addDeckBtn = new Button();
            deleteDeckBtn = new Button();
            deleteCardBtn = new Button();
            addCardBtn = new Button();
            SuspendLayout();
            // 
            // displayNickname
            // 
            displayNickname.AutoSize = true;
            displayNickname.Font = new Font("Segoe UI", 20F);
            displayNickname.Location = new Point(295, 40);
            displayNickname.Name = "displayNickname";
            displayNickname.Size = new Size(212, 37);
            displayNickname.TabIndex = 1;
            displayNickname.Text = "Hello, nickname.";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(61, 529);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 23);
            btnLogOut.TabIndex = 2;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // deckList
            // 
            deckList.FormattingEnabled = true;
            deckList.Location = new Point(61, 156);
            deckList.Name = "deckList";
            deckList.Size = new Size(196, 229);
            deckList.TabIndex = 3;
            deckList.SelectedIndexChanged += deckList_SelectedIndexChanged;
            // 
            // cardList
            // 
            cardList.FormattingEnabled = true;
            cardList.Location = new Point(332, 156);
            cardList.Name = "cardList";
            cardList.Size = new Size(196, 229);
            cardList.TabIndex = 4;
            cardList.SelectedIndexChanged += cardList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 135);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Available Decks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 135);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 6;
            label2.Text = "Available Flashcards";
            // 
            // addDeckBtn
            // 
            addDeckBtn.Location = new Point(61, 391);
            addDeckBtn.Name = "addDeckBtn";
            addDeckBtn.Size = new Size(75, 23);
            addDeckBtn.TabIndex = 7;
            addDeckBtn.Text = "New Deck";
            addDeckBtn.UseVisualStyleBackColor = true;
            addDeckBtn.Click += addDeckBtn_Click;
            // 
            // deleteDeckBtn
            // 
            deleteDeckBtn.Enabled = false;
            deleteDeckBtn.Location = new Point(142, 391);
            deleteDeckBtn.Name = "deleteDeckBtn";
            deleteDeckBtn.Size = new Size(92, 23);
            deleteDeckBtn.TabIndex = 8;
            deleteDeckBtn.Text = "Delete Deck";
            deleteDeckBtn.UseVisualStyleBackColor = true;
            deleteDeckBtn.Click += deleteDeckBtn_Click;
            // 
            // deleteCardBtn
            // 
            deleteCardBtn.Enabled = false;
            deleteCardBtn.Location = new Point(433, 391);
            deleteCardBtn.Name = "deleteCardBtn";
            deleteCardBtn.Size = new Size(115, 23);
            deleteCardBtn.TabIndex = 10;
            deleteCardBtn.Text = "Delete Flashcard";
            deleteCardBtn.UseVisualStyleBackColor = true;
            deleteCardBtn.Click += deleteCardBtn_Click;
            // 
            // addCardBtn
            // 
            addCardBtn.Location = new Point(332, 391);
            addCardBtn.Name = "addCardBtn";
            addCardBtn.Size = new Size(95, 23);
            addCardBtn.TabIndex = 9;
            addCardBtn.Text = "New Flashcard";
            addCardBtn.UseVisualStyleBackColor = true;
            addCardBtn.Click += addCardBtn_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteCardBtn);
            Controls.Add(addCardBtn);
            Controls.Add(deleteDeckBtn);
            Controls.Add(addDeckBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cardList);
            Controls.Add(deckList);
            Controls.Add(btnLogOut);
            Controls.Add(displayNickname);
            Name = "dashboard";
            Size = new Size(800, 600);
            Load += dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label displayNickname;
        private Button btnLogOut;
        private ListBox deckList;
        private ListBox cardList;
        private Label label1;
        private Label label2;
        private Button addDeckBtn;
        private Button deleteDeckBtn;
        private Button deleteCardBtn;
        private Button addCardBtn;
    }
}
