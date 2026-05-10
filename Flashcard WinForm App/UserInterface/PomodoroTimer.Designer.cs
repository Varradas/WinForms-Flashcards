namespace Flashcard_WinForm_App.UserInterface
{
    partial class PomodoroTimer
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
            lblTimer = new Label();
            btnStart = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.Transparent;
            lblTimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(6, 6);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(52, 21);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(78, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(45, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(129, 6);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(45, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // PomodoroTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTimer);
            Name = "PomodoroTimer";
            Size = new Size(177, 34);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer countdownTimer;
    }
}
