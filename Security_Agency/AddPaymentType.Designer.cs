namespace Security_Agency
{
    partial class AddPaymentType
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
            this.textBoxPaymentCostInput = new System.Windows.Forms.TextBox();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxPaymentNameInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddPaymentType = new System.Windows.Forms.Button();
            this.buttonAddPaymentType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Сумма платежа";
            // 
            // textBoxPaymentCostInput
            // 
            this.textBoxPaymentCostInput.Location = new System.Drawing.Point(11, 64);
            this.textBoxPaymentCostInput.Name = "textBoxPaymentCostInput";
            this.textBoxPaymentCostInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPaymentCostInput.TabIndex = 52;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(39, 9);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(129, 13);
            this.labelSurnameInput.TabIndex = 51;
            this.labelSurnameInput.Text = "Наименование платежа";
            // 
            // textBoxPaymentNameInput
            // 
            this.textBoxPaymentNameInput.Location = new System.Drawing.Point(11, 25);
            this.textBoxPaymentNameInput.Name = "textBoxPaymentNameInput";
            this.textBoxPaymentNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPaymentNameInput.TabIndex = 50;
            // 
            // buttonCancelAddPaymentType
            // 
            this.buttonCancelAddPaymentType.Location = new System.Drawing.Point(134, 90);
            this.buttonCancelAddPaymentType.Name = "buttonCancelAddPaymentType";
            this.buttonCancelAddPaymentType.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddPaymentType.TabIndex = 49;
            this.buttonCancelAddPaymentType.Text = "Отмена";
            this.buttonCancelAddPaymentType.UseVisualStyleBackColor = true;
            // 
            // buttonAddPaymentType
            // 
            this.buttonAddPaymentType.Location = new System.Drawing.Point(11, 90);
            this.buttonAddPaymentType.Name = "buttonAddPaymentType";
            this.buttonAddPaymentType.Size = new System.Drawing.Size(117, 38);
            this.buttonAddPaymentType.TabIndex = 48;
            this.buttonAddPaymentType.Text = "Добавить платеж ";
            this.buttonAddPaymentType.UseVisualStyleBackColor = true;
            // 
            // AddPaymentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPaymentCostInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPaymentNameInput);
            this.Controls.Add(this.buttonCancelAddPaymentType);
            this.Controls.Add(this.buttonAddPaymentType);
            this.Name = "AddPaymentType";
            this.Text = "Добавление платежа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPaymentCostInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxPaymentNameInput;
        private System.Windows.Forms.Button buttonCancelAddPaymentType;
        private System.Windows.Forms.Button buttonAddPaymentType;
    }
}