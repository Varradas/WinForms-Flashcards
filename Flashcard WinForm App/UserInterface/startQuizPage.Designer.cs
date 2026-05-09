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
            rbOp4 = new RadioButton();
            rbOp2 = new RadioButton();
            rbOp3 = new RadioButton();
            rbOp1 = new RadioButton();
            btnSubmit = new Button();
            pnlMultipleChoice.SuspendLayout();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(145, 135);
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
            pnlMultipleChoice.Controls.Add(rbOp4);
            pnlMultipleChoice.Controls.Add(rbOp2);
            pnlMultipleChoice.Controls.Add(rbOp3);
            pnlMultipleChoice.Controls.Add(rbOp1);
            pnlMultipleChoice.Location = new Point(133, 249);
            pnlMultipleChoice.Name = "pnlMultipleChoice";
            pnlMultipleChoice.Size = new Size(519, 106);
            pnlMultipleChoice.TabIndex = 2;
            // 
            // rbOp4
            // 
            rbOp4.AutoSize = true;
            rbOp4.Location = new Point(282, 60);
            rbOp4.Name = "rbOp4";
            rbOp4.Size = new Size(66, 19);
            rbOp4.TabIndex = 6;
            rbOp4.TabStop = true;
            rbOp4.Text = "choice4";
            rbOp4.UseVisualStyleBackColor = true;
            // 
            // rbOp2
            // 
            rbOp2.AutoSize = true;
            rbOp2.Location = new Point(282, 23);
            rbOp2.Name = "rbOp2";
            rbOp2.Size = new Size(66, 19);
            rbOp2.TabIndex = 7;
            rbOp2.TabStop = true;
            rbOp2.Text = "choice2";
            rbOp2.UseVisualStyleBackColor = true;
            // 
            // rbOp3
            // 
            rbOp3.AutoSize = true;
            rbOp3.Location = new Point(153, 60);
            rbOp3.Name = "rbOp3";
            rbOp3.Size = new Size(66, 19);
            rbOp3.TabIndex = 5;
            rbOp3.TabStop = true;
            rbOp3.Text = "choice3";
            rbOp3.UseVisualStyleBackColor = true;
            // 
            // rbOp1
            // 
            rbOp1.AutoSize = true;
            rbOp1.Location = new Point(153, 23);
            rbOp1.Name = "rbOp1";
            rbOp1.Size = new Size(66, 19);
            rbOp1.TabIndex = 3;
            rbOp1.TabStop = true;
            rbOp1.Text = "choice1";
            rbOp1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(334, 372);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit Answer";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // startQuizPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
