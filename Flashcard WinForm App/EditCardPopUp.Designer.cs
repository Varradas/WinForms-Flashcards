namespace Flashcard_WinForm_App
{
    partial class EditCardPopUp
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
            inputAns = new TextBox();
            label2 = new Label();
            cancelBtn = new Button();
            addBtn = new Button();
            inputDef = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // inputAns
            // 
            inputAns.Location = new Point(54, 159);
            inputAns.Name = "inputAns";
            inputAns.Size = new Size(341, 23);
            inputAns.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 141);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 10;
            label2.Text = "Answer";
            // 
            // cancelBtn
            // 
            cancelBtn.DialogResult = DialogResult.Cancel;
            cancelBtn.Location = new Point(361, 405);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.DialogResult = DialogResult.OK;
            addBtn.Location = new Point(456, 405);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 8;
            addBtn.Text = "Confirm";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // inputDef
            // 
            inputDef.Location = new Point(54, 86);
            inputDef.Name = "inputDef";
            inputDef.Size = new Size(341, 23);
            inputDef.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 6;
            label1.Text = "Definition";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 27);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "Edit This Card";
            // 
            // EditCardPopUp
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(584, 461);
            Controls.Add(label3);
            Controls.Add(inputAns);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(inputDef);
            Controls.Add(label1);
            Name = "EditCardPopUp";
            Text = "EditCardPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputAns;
        private Label label2;
        private Button cancelBtn;
        private Button addBtn;
        private TextBox inputDef;
        private Label label1;
        private Label label3;
    }
}