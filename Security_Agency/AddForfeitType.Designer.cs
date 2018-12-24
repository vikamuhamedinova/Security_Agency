namespace Security_Agency
{
    partial class AddForfeitType
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxForfeitCostInput = new System.Windows.Forms.TextBox();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxForfeitNameInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddForfeitType = new System.Windows.Forms.Button();
            this.buttonAddForfeitType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Сумма штрафа";
            // 
            // textBoxForfeitCostInput
            // 
            this.textBoxForfeitCostInput.Location = new System.Drawing.Point(7, 64);
            this.textBoxForfeitCostInput.Name = "textBoxForfeitCostInput";
            this.textBoxForfeitCostInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxForfeitCostInput.TabIndex = 46;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(35, 9);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(125, 13);
            this.labelSurnameInput.TabIndex = 45;
            this.labelSurnameInput.Text = "Наименование штрафа";
            // 
            // textBoxForfeitNameInput
            // 
            this.textBoxForfeitNameInput.Location = new System.Drawing.Point(7, 25);
            this.textBoxForfeitNameInput.Name = "textBoxForfeitNameInput";
            this.textBoxForfeitNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxForfeitNameInput.TabIndex = 44;
            // 
            // buttonCancelAddForfeitType
            // 
            this.buttonCancelAddForfeitType.Location = new System.Drawing.Point(130, 90);
            this.buttonCancelAddForfeitType.Name = "buttonCancelAddForfeitType";
            this.buttonCancelAddForfeitType.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddForfeitType.TabIndex = 43;
            this.buttonCancelAddForfeitType.Text = "Отмена";
            this.buttonCancelAddForfeitType.UseVisualStyleBackColor = true;
            // 
            // buttonAddForfeitType
            // 
            this.buttonAddForfeitType.Location = new System.Drawing.Point(7, 90);
            this.buttonAddForfeitType.Name = "buttonAddForfeitType";
            this.buttonAddForfeitType.Size = new System.Drawing.Size(117, 38);
            this.buttonAddForfeitType.TabIndex = 42;
            this.buttonAddForfeitType.Text = "Добавить штраф";
            this.buttonAddForfeitType.UseVisualStyleBackColor = true;
            // 
            // AddForfeitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForfeitCostInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxForfeitNameInput);
            this.Controls.Add(this.buttonCancelAddForfeitType);
            this.Controls.Add(this.buttonAddForfeitType);
            this.Name = "AddForfeitType";
            this.Text = "Добавление штрафа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxForfeitCostInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxForfeitNameInput;
        private System.Windows.Forms.Button buttonCancelAddForfeitType;
        private System.Windows.Forms.Button buttonAddForfeitType;
    }
}