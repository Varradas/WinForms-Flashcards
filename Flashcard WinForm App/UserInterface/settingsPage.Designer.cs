namespace Flashcard_WinForm_App.UserInterface
{
    partial class settingsPage
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
            chkEnableTimer = new CheckBox();
            numWorkTime = new NumericUpDown();
            numBreakTime = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pnlContent = new Panel();
            btnSave = new Button();
            btnBack = new Button();
            btnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)numWorkTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBreakTime).BeginInit();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // chkEnableTimer
            // 
            chkEnableTimer.AutoSize = true;
            chkEnableTimer.Location = new Point(58, 129);
            chkEnableTimer.Name = "chkEnableTimer";
            chkEnableTimer.Size = new Size(155, 19);
            chkEnableTimer.TabIndex = 0;
            chkEnableTimer.Text = "Enable Pomodoro TImer";
            chkEnableTimer.UseVisualStyleBackColor = true;
            chkEnableTimer.CheckedChanged += chkEnableTimer_CheckedChanged;
            // 
            // numWorkTime
            // 
            numWorkTime.Location = new Point(114, 24);
            numWorkTime.Name = "numWorkTime";
            numWorkTime.Size = new Size(120, 23);
            numWorkTime.TabIndex = 1;
            // 
            // numBreakTime
            // 
            numBreakTime.Location = new Point(114, 69);
            numBreakTime.Name = "numBreakTime";
            numBreakTime.Size = new Size(120, 23);
            numBreakTime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 3;
            label1.Text = "User Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 26);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Work Time (Min)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 71);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Break Time (Min)";
            // 
            // pnlContent
            // 
            pnlContent.BorderStyle = BorderStyle.Fixed3D;
            pnlContent.Controls.Add(numBreakTime);
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(numWorkTime);
            pnlContent.Controls.Add(label2);
            pnlContent.Location = new Point(50, 154);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(273, 113);
            pnlContent.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(686, 549);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBack.Location = new Point(605, 549);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteUser.ForeColor = Color.Red;
            btnDeleteUser.Location = new Point(50, 549);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(99, 23);
            btnDeleteUser.TabIndex = 9;
            btnDeleteUser.Text = "Delete Account";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // settingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteUser);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(pnlContent);
            Controls.Add(label1);
            Controls.Add(chkEnableTimer);
            Name = "settingsPage";
            Size = new Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)numWorkTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBreakTime).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkEnableTimer;
        private NumericUpDown numWorkTime;
        private NumericUpDown numBreakTime;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel pnlContent;
        private Button btnSave;
        private Button btnBack;
        private Button btnDeleteUser;
    }
}
