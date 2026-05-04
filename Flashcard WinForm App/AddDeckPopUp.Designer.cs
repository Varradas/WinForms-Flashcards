namespace Flashcard_WinForm_App
{
    partial class AddDeckPopUp
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
            inputLabel = new TextBox();
            addBtn = new Button();
            cancelBtn = new Button();
            inputDescription = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 52);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Label";
            // 
            // inputLabel
            // 
            inputLabel.Location = new Point(74, 70);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(341, 23);
            inputLabel.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.DialogResult = DialogResult.OK;
            addBtn.Location = new Point(476, 424);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(381, 424);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // inputDescription
            // 
            inputDescription.Location = new Point(74, 143);
            inputDescription.Name = "inputDescription";
            inputDescription.Size = new Size(341, 23);
            inputDescription.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 125);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // AddDeckPopUp
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(584, 461);
            Controls.Add(inputDescription);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(inputLabel);
            Controls.Add(label1);
            Name = "AddDeckPopUp";
            Text = "AddDeckPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputLabel;
        private Button addBtn;
        private Button cancelBtn;
        private TextBox inputDescription;
        private Label label2;
    }
}