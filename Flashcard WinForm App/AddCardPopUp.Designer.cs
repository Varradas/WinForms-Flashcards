namespace Flashcard_WinForm_App
{
    partial class AddCardPopUp
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
            inputDef = new TextBox();
            addBtn = new Button();
            cancelBtn = new Button();
            inputAns = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 52);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Definition";
            // 
            // inputDef
            // 
            inputDef.Location = new Point(74, 70);
            inputDef.Name = "inputDef";
            inputDef.Size = new Size(341, 23);
            inputDef.TabIndex = 1;
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
            // inputAns
            // 
            inputAns.Location = new Point(74, 143);
            inputAns.Name = "inputAns";
            inputAns.Size = new Size(341, 23);
            inputAns.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 125);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Answer";
            // 
            // AddCardPopUp
            // 
            AcceptButton = addBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(584, 461);
            Controls.Add(inputAns);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(addBtn);
            Controls.Add(inputDef);
            Controls.Add(label1);
            Name = "AddCardPopUp";
            Text = "Add Card";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputDef;
        private Button addBtn;
        private Button cancelBtn;
        private TextBox inputAns;
        private Label label2;
    }
}