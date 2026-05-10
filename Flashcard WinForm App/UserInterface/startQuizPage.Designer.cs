namespace Flashcard_WinForm_App.UserInterface
{
    partial class startQuizPage
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
            lblQuestion = new Label();
            inputAnswer = new TextBox();
            pnlMultipleChoice = new Panel();
            radioLabel1 = new Label();
            rbOp4 = new RadioButton();
            rbOp2 = new RadioButton();
            rbOp3 = new RadioButton();
            rbOp1 = new RadioButton();
            btnSubmit = new Button();
            radioLabel3 = new Label();
            radioLabel2 = new Label();
            radioLabel4 = new Label();
            pnlMultipleChoice.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(143, 132);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(486, 56);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "questionLabel";
            lblQuestion.TextAlign = ContentAlignment.TopCenter;
            // 
            // inputAnswer
            // 
            inputAnswer.Location = new Point(267, 211);
            inputAnswer.Name = "inputAnswer";
            inputAnswer.PlaceholderText = "Answer...";
            inputAnswer.Size = new Size(239, 23);
            inputAnswer.TabIndex = 1;
            // 
            // pnlMultipleChoice
            // 
            pnlMultipleChoice.Controls.Add(radioLabel4);
            pnlMultipleChoice.Controls.Add(radioLabel2);
            pnlMultipleChoice.Controls.Add(radioLabel3);
            pnlMultipleChoice.Controls.Add(radioLabel1);
            pnlMultipleChoice.Controls.Add(rbOp4);
            pnlMultipleChoice.Controls.Add(rbOp2);
            pnlMultipleChoice.Controls.Add(rbOp3);
            pnlMultipleChoice.Controls.Add(rbOp1);
            pnlMultipleChoice.Location = new Point(133, 249);
            pnlMultipleChoice.Name = "pnlMultipleChoice";
            pnlMultipleChoice.Size = new Size(519, 145);
            pnlMultipleChoice.TabIndex = 2;
            // 
            // radioLabel1
            // 
            radioLabel1.Location = new Point(140, 22);
            radioLabel1.Name = "radioLabel1";
            radioLabel1.Size = new Size(105, 56);
            radioLabel1.TabIndex = 5;
            radioLabel1.Text = "choice 1";
            // 
            // rbOp4
            // 
            rbOp4.AutoSize = true;
            rbOp4.Location = new Point(266, 81);
            rbOp4.Name = "rbOp4";
            rbOp4.Size = new Size(14, 13);
            rbOp4.TabIndex = 6;
            rbOp4.TabStop = true;
            rbOp4.UseVisualStyleBackColor = true;
            // 
            // rbOp2
            // 
            rbOp2.AutoSize = true;
            rbOp2.Location = new Point(266, 23);
            rbOp2.Name = "rbOp2";
            rbOp2.Size = new Size(14, 13);
            rbOp2.TabIndex = 7;
            rbOp2.TabStop = true;
            rbOp2.UseVisualStyleBackColor = true;
            // 
            // rbOp3
            // 
            rbOp3.AutoSize = true;
            rbOp3.Location = new Point(120, 81);
            rbOp3.Name = "rbOp3";
            rbOp3.Size = new Size(14, 13);
            rbOp3.TabIndex = 5;
            rbOp3.TabStop = true;
            rbOp3.UseVisualStyleBackColor = true;
            // 
            // rbOp1
            // 
            rbOp1.AutoSize = true;
            rbOp1.Location = new Point(120, 23);
            rbOp1.Name = "rbOp1";
            rbOp1.Size = new Size(14, 13);
            rbOp1.TabIndex = 3;
            rbOp1.TabStop = true;
            rbOp1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(334, 400);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Answer";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // radioLabel3
            // 
            radioLabel3.Location = new Point(140, 81);
            radioLabel3.Name = "radioLabel3";
            radioLabel3.Size = new Size(105, 56);
            radioLabel3.TabIndex = 8;
            radioLabel3.Text = "choice 1";
            // 
            // radioLabel2
            // 
            radioLabel2.Location = new Point(286, 22);
            radioLabel2.Name = "radioLabel2";
            radioLabel2.Size = new Size(105, 56);
            radioLabel2.TabIndex = 9;
            radioLabel2.Text = "choice 1";
            // 
            // radioLabel4
            // 
            radioLabel4.Location = new Point(286, 81);
            radioLabel4.Name = "radioLabel4";
            radioLabel4.Size = new Size(105, 56);
            radioLabel4.TabIndex = 10;
            radioLabel4.Text = "choice 1";
            // 
            // startQuizPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnSubmit);
            Controls.Add(pnlMultipleChoice);
            Controls.Add(inputAnswer);
            Controls.Add(lblQuestion);
            Name = "startQuizPage";
            Size = new Size(800, 600);
            Load += startQuizPage_Load;
            pnlMultipleChoice.ResumeLayout(false);
            pnlMultipleChoice.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox inputAnswer;
        private Panel pnlMultipleChoice;
        private RadioButton rbOp1;
        private Button btnSubmit;
        private RadioButton rbOp3;
        private RadioButton rbOp4;
        private RadioButton rbOp2;
        private Label radioLabel1;
        private Label radioLabel4;
        private Label radioLabel2;
        private Label radioLabel3;
    }
}
