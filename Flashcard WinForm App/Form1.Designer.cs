namespace Flashcard_WinForm_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            pnlContent = new Panel();
            pnlLockOverlay = new Panel();
            label1 = new Label();
            pomodoroTimer = new Flashcard_WinForm_App.UserInterface.PomodoroTimer();
            pnlLockOverlay.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 450);
            pnlContent.TabIndex = 0;
            // 
            // pnlLockOverlay
            // 
            pnlLockOverlay.Controls.Add(label1);
            pnlLockOverlay.Dock = DockStyle.Fill;
            pnlLockOverlay.Location = new Point(0, 0);
            pnlLockOverlay.Name = "pnlLockOverlay";
            pnlLockOverlay.Size = new Size(800, 450);
            pnlLockOverlay.TabIndex = 1;
            pnlLockOverlay.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 192);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "BREAK TIME";
            // 
            // pomodoroTimer
            // 
            pomodoroTimer.BackColor = Color.Transparent;
            pomodoroTimer.BreakDurationMinutes = 5;
            pomodoroTimer.Location = new Point(550, 0);
            pomodoroTimer.Name = "pomodoroTimer";
            pomodoroTimer.Size = new Size(177, 34);
            pomodoroTimer.TabIndex = 1;
            pomodoroTimer.WorkDurationMinutes = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pomodoroTimer);
            Controls.Add(pnlLockOverlay);
            Controls.Add(pnlContent);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlLockOverlay.ResumeLayout(false);
            pnlLockOverlay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private Panel pnlContent;
        private Panel pnlLockOverlay;
        private Label label1;
        internal UserInterface.PomodoroTimer pomodoroTimer;
    }
}
