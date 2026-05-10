namespace Flashcard_WinForm_App.UserInterface
{
    partial class homePage
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
            btnLogout = new Button();
            deckList = new ListBox();
            placeholderTextDeck = new Label();
            btnAddDeck = new Button();
            btnDeleteDeck = new Button();
            btnImportDeck = new Button();
            pnlContentSide = new Panel();
            placeholderTextDisplay = new Label();
            btnExportDeck = new Button();
            btnSettings = new Button();
            displayNickname = new Label();
            pnlContentSide.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.Location = new Point(685, 549);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // deckList
            // 
            deckList.FormattingEnabled = true;
            deckList.Location = new Point(40, 36);
            deckList.Name = "deckList";
            deckList.Size = new Size(266, 439);
            deckList.TabIndex = 4;
            deckList.SelectedIndexChanged += deckList_SelectedIndexChanged;
            // 
            // placeholderTextDeck
            // 
            placeholderTextDeck.AutoSize = true;
            placeholderTextDeck.BackColor = Color.White;
            placeholderTextDeck.Location = new Point(121, 257);
            placeholderTextDeck.Name = "placeholderTextDeck";
            placeholderTextDeck.Size = new Size(111, 15);
            placeholderTextDeck.TabIndex = 5;
            placeholderTextDeck.Text = "No Decks Available.";
            // 
            // btnAddDeck
            // 
            btnAddDeck.Location = new Point(39, 480);
            btnAddDeck.Name = "btnAddDeck";
            btnAddDeck.Size = new Size(86, 23);
            btnAddDeck.TabIndex = 6;
            btnAddDeck.Text = "New Deck";
            btnAddDeck.UseVisualStyleBackColor = true;
            btnAddDeck.Click += btnAddDeck_Click;
            // 
            // btnDeleteDeck
            // 
            btnDeleteDeck.Enabled = false;
            btnDeleteDeck.Location = new Point(40, 509);
            btnDeleteDeck.Name = "btnDeleteDeck";
            btnDeleteDeck.Size = new Size(85, 23);
            btnDeleteDeck.TabIndex = 7;
            btnDeleteDeck.Text = "Delete Deck";
            btnDeleteDeck.UseVisualStyleBackColor = true;
            btnDeleteDeck.Click += btnDeleteDeck_Click;
            // 
            // btnImportDeck
            // 
            btnImportDeck.Location = new Point(131, 481);
            btnImportDeck.Name = "btnImportDeck";
            btnImportDeck.Size = new Size(85, 23);
            btnImportDeck.TabIndex = 8;
            btnImportDeck.Text = "Import Deck";
            btnImportDeck.UseVisualStyleBackColor = true;
            btnImportDeck.Click += btnImportDeck_Click;
            // 
            // pnlContentSide
            // 
            pnlContentSide.BorderStyle = BorderStyle.FixedSingle;
            pnlContentSide.Controls.Add(placeholderTextDisplay);
            pnlContentSide.Location = new Point(312, 36);
            pnlContentSide.Name = "pnlContentSide";
            pnlContentSide.Size = new Size(448, 439);
            pnlContentSide.TabIndex = 9;
            // 
            // placeholderTextDisplay
            // 
            placeholderTextDisplay.AutoSize = true;
            placeholderTextDisplay.BackColor = SystemColors.ButtonFace;
            placeholderTextDisplay.Location = new Point(166, 221);
            placeholderTextDisplay.Name = "placeholderTextDisplay";
            placeholderTextDisplay.Size = new Size(102, 15);
            placeholderTextDisplay.TabIndex = 10;
            placeholderTextDisplay.Text = "No Deck Selected.";
            // 
            // btnExportDeck
            // 
            btnExportDeck.Location = new Point(131, 509);
            btnExportDeck.Name = "btnExportDeck";
            btnExportDeck.Size = new Size(85, 23);
            btnExportDeck.TabIndex = 10;
            btnExportDeck.Text = "Export Deck";
            btnExportDeck.UseVisualStyleBackColor = true;
            btnExportDeck.Click += btnExportDeck_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSettings.Location = new Point(685, 520);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 11;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // displayNickname
            // 
            displayNickname.AutoSize = true;
            displayNickname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayNickname.Location = new Point(39, 3);
            displayNickname.Name = "displayNickname";
            displayNickname.Size = new Size(166, 30);
            displayNickname.TabIndex = 12;
            displayNickname.Text = "Hello, nickname.";
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(displayNickname);
            Controls.Add(btnSettings);
            Controls.Add(btnExportDeck);
            Controls.Add(pnlContentSide);
            Controls.Add(btnImportDeck);
            Controls.Add(btnDeleteDeck);
            Controls.Add(btnAddDeck);
            Controls.Add(placeholderTextDeck);
            Controls.Add(deckList);
            Controls.Add(btnLogout);
            Margin = new Padding(0);
            Name = "homePage";
            Size = new Size(800, 600);
            Load += homePage_Load;
            pnlContentSide.ResumeLayout(false);
            pnlContentSide.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogout;
        private ListBox deckList;
        private Label placeholderTextDeck;
        private Button btnAddDeck;
        private Button btnDeleteDeck;
        private Button btnImportDeck;
        private Panel pnlContentSide;
        private Label placeholderTextDisplay;
        private Button btnExportDeck;
        private Button btnSettings;
        private Label displayNickname;
    }
}
