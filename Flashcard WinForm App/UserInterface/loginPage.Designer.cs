namespace Flashcard_WinForm_App.UserInterface
{
    partial class loginPage
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
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(211, 106);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(141, 168);
            usernameInput.Name = "usernameInput";
            usernameInput.PlaceholderText = "Username";
            usernameInput.Size = new Size(202, 23);
            usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(141, 210);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "Password";
            passwordInput.Size = new Size(202, 23);
            passwordInput.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(205, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 25);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(205, 316);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 25);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 287);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 6;
            label2.Text = "New User? Register Below ↓";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(162, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "loginPage";
            Size = new Size(500, 500);
            Load += loginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button btnLogin;
        private Button btnRegister;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
