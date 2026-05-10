namespace Flashcard_WinForm_App
{
    partial class EditDeckPopUp
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
            inputDescription = new TextBox();
            label2 = new Label();
            cancelBtn = new Button();
            addBtn = new Button();
            inputLabel = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputDescription
            // 
            inputDescription.Location = new Point(75, 142);
            inputDescription.Name = "inputDescription";
            inputDescription.Size = new Size(341, 23);
            inputDescription.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Description";
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(382, 423);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.DialogResult = DialogResult.OK;
            addBtn.Location = new Point(477, 423);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 8;
            addBtn.Text = "Confirm";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // inputLabel
            // 
            inputLabel.Location = new Point(75, 69);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(341, 23);
            inputLabel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 51);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 6;
            label1.Text = "Label";
            // 
            // EditDeckPopUp
            // 
            AcceptButton = addBtn;
            AccessibleDescription = "";
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
            Name = "EditDeckPopUp";
            Text = "Edit Deck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputDescription;
        private Label label2;
        private Button cancelBtn;
        private Button addBtn;
        private TextBox inputLabel;
        private Label label1;
    }
}