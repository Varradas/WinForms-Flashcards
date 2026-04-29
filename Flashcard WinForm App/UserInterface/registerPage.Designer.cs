namespace Flashcard_WinForm_App.UserInterface
{
    partial class registerPage
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
            btnRegister = new Button();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            nicknameInput = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(132, 86);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 1;
            label1.Text = "This is the Register Page.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(213, 313);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(149, 210);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(202, 23);
            passwordInput.TabIndex = 7;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(149, 165);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Username";
            usernameInput.Size = new Size(202, 23);
            usernameInput.TabIndex = 6;
            // 
            // nicknameInput
            // 
            nicknameInput.Location = new Point(149, 255);
            nicknameInput.Name = "nicknameInput";
            nicknameInput.PlaceholderText = "Nickname";
            nicknameInput.Size = new Size(202, 23);
            nicknameInput.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.Location = new Point(36, 451);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // registerPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(nicknameInput);
            Controls.Add(btnRegister);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(label1);
            Name = "registerPage";
            Size = new Size(500, 500);
            Load += registerPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegister;
        private TextBox passwordInput;
        private TextBox usernameInput;
        private TextBox nicknameInput;
        private Button btnBack;
    }
}
