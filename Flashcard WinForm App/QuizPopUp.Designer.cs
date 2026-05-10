namespace Flashcard_WinForm_App
{
    partial class QuizPopUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnStart = new Button();
            btnCancel = new Button();
            txtItems = new TextBox();
            label2 = new Label();
            masteredFilter = new CheckBox();
            choiceQuizType = new ComboBox();
            label3 = new Label();
            pnlContent = new Panel();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 10);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Quiz Setup";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(360, 204);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(279, 204);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtItems
            // 
            txtItems.Location = new Point(154, 64);
            txtItems.Name = "txtItems";
            txtItems.Size = new Size(137, 23);
            txtItems.TabIndex = 3;
            txtItems.KeyPress += txtItems_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 67);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Number of Items:";
            // 
            // masteredFilter
            // 
            masteredFilter.AutoSize = true;
            masteredFilter.Location = new Point(154, 145);
            masteredFilter.Name = "masteredFilter";
            masteredFilter.Size = new Size(176, 19);
            masteredFilter.TabIndex = 5;
            masteredFilter.Text = "Exclude Mastered Flashcards";
            masteredFilter.UseVisualStyleBackColor = true;
            // 
            // choiceQuizType
            // 
            choiceQuizType.FormattingEnabled = true;
            choiceQuizType.Items.AddRange(new object[] { "Identification", "Multiple Choice" });
            choiceQuizType.Location = new Point(154, 102);
            choiceQuizType.Name = "choiceQuizType";
            choiceQuizType.Size = new Size(137, 23);
            choiceQuizType.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 105);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Type of Quiz:";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(choiceQuizType);
            pnlContent.Controls.Add(label3);
            pnlContent.Controls.Add(label1);
            pnlContent.Controls.Add(btnStart);
            pnlContent.Controls.Add(masteredFilter);
            pnlContent.Controls.Add(btnCancel);
            pnlContent.Controls.Add(label2);
            pnlContent.Controls.Add(txtItems);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(447, 239);
            pnlContent.TabIndex = 8;
            // 
            // QuizPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(447, 239);
            Controls.Add(pnlContent);
            Name = "QuizPopUp";
            Text = "Quiz";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnStart;
        private Button btnCancel;
        private TextBox txtItems;
        private Label label2;
        private CheckBox masteredFilter;
        private ComboBox choiceQuizType;
        private Label label3;
        private Panel pnlContent;
    }
}