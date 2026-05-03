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
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
