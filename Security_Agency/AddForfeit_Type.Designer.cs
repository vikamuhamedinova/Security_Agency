namespace Security_Agency
{
    partial class AddForfeit_Type
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
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Сумма штрафа";
            // 
            // textBoxForfeitCostInput
            // 
            this.textBoxForfeitCostInput.Location = new System.Drawing.Point(9, 79);
            this.textBoxForfeitCostInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxForfeitCostInput.Name = "textBoxForfeitCostInput";
            this.textBoxForfeitCostInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxForfeitCostInput.TabIndex = 46;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(47, 11);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(163, 17);
            this.labelSurnameInput.TabIndex = 45;
            this.labelSurnameInput.Text = "Наименование штрафа";
            // 
            // textBoxForfeitNameInput
            // 
            this.textBoxForfeitNameInput.Location = new System.Drawing.Point(9, 31);
            this.textBoxForfeitNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxForfeitNameInput.Name = "textBoxForfeitNameInput";
            this.textBoxForfeitNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxForfeitNameInput.TabIndex = 44;
            // 
            // buttonCancelAddForfeitType
            // 
            this.buttonCancelAddForfeitType.Location = new System.Drawing.Point(173, 111);
            this.buttonCancelAddForfeitType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddForfeitType.Name = "buttonCancelAddForfeitType";
            this.buttonCancelAddForfeitType.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddForfeitType.TabIndex = 43;
            this.buttonCancelAddForfeitType.Text = "Отмена";
            this.buttonCancelAddForfeitType.UseVisualStyleBackColor = true;
            this.buttonCancelAddForfeitType.Click += new System.EventHandler(this.ButtonCancelAddForfeitType_Click);
            // 
            // buttonAddForfeitType
            // 
            this.buttonAddForfeitType.Location = new System.Drawing.Point(9, 111);
            this.buttonAddForfeitType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddForfeitType.Name = "buttonAddForfeitType";
            this.buttonAddForfeitType.Size = new System.Drawing.Size(156, 47);
            this.buttonAddForfeitType.TabIndex = 42;
            this.buttonAddForfeitType.Text = "Добавить штраф";
            this.buttonAddForfeitType.UseVisualStyleBackColor = true;
            this.buttonAddForfeitType.Click += new System.EventHandler(this.ButtonAddForfeitType_Click);
            // 
            // AddForfeitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForfeitCostInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxForfeitNameInput);
            this.Controls.Add(this.buttonCancelAddForfeitType);
            this.Controls.Add(this.buttonAddForfeitType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddForfeitType";
            this.Text = "Добавление штрафа";
            this.Load += new System.EventHandler(this.AddForfeitType_Load);
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