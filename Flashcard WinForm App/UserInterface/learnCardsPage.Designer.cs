namespace Flashcard_WinForm_App.UserInterface
{
    partial class learnCardsPage
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
            components = new System.ComponentModel.Container();
            cardLabel = new Label();
            cardOuter = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            btnFlip = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            btnBack = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            checkBox1 = new CheckBox();
            timer3 = new System.Windows.Forms.Timer(components);
            cardOuter.SuspendLayout();
            SuspendLayout();
            // 
            // cardLabel
            // 
            cardLabel.Location = new Point(31, 25);
            cardLabel.Name = "cardLabel";
            cardLabel.Size = new Size(295, 155);
            cardLabel.TabIndex = 0;
            cardLabel.Text = "label1";
            cardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardOuter
            // 
            cardOuter.BorderStyle = BorderStyle.FixedSingle;
            cardOuter.Controls.Add(cardLabel);
            cardOuter.Location = new Point(46, 113);
            cardOuter.Name = "cardOuter";
            cardOuter.Size = new Size(356, 206);
            cardOuter.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 16;
            timer1.Tick += timer1_Tick;
            // 
            // btnFlip
            // 
            btnFlip.Location = new Point(182, 325);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(75, 23);
            btnFlip.TabIndex = 2;
            btnFlip.Text = "Flip Card";
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // timer2
            // 
            timer2.Interval = 16;
            timer2.Tick += timer2_Tick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(46, 380);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(373, 325);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(46, 325);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(31, 23);
            btnPrevious.TabIndex = 5;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 354);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mastered";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timer3
            // 
            timer3.Interval = 16;
            timer3.Tick += timer3_Tick;
            // 
            // learnCardsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox1);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(btnFlip);
            Controls.Add(cardOuter);
            Name = "learnCardsPage";
            Size = new Size(448, 439);
            cardOuter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cardLabel;
        private Panel cardOuter;
        private System.Windows.Forms.Timer timer1;
        private Button btnFlip;
        private System.Windows.Forms.Timer timer2;
        private Button btnBack;
        private Button btnNext;
        private Button btnPrevious;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timer3;
    }
}
