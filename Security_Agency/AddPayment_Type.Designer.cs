namespace Security_Agency
{
    partial class AddPayment_Type
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
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Сумма платежа";
            // 
            // textBoxPaymentCostInput
            // 
            this.textBoxPaymentCostInput.Location = new System.Drawing.Point(15, 79);
            this.textBoxPaymentCostInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaymentCostInput.Name = "textBoxPaymentCostInput";
            this.textBoxPaymentCostInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPaymentCostInput.TabIndex = 52;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(52, 11);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(166, 17);
            this.labelSurnameInput.TabIndex = 51;
            this.labelSurnameInput.Text = "Наименование платежа";
            // 
            // textBoxPaymentNameInput
            // 
            this.textBoxPaymentNameInput.Location = new System.Drawing.Point(15, 31);
            this.textBoxPaymentNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPaymentNameInput.Name = "textBoxPaymentNameInput";
            this.textBoxPaymentNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPaymentNameInput.TabIndex = 50;
            // 
            // buttonCancelAddPaymentType
            // 
            this.buttonCancelAddPaymentType.Location = new System.Drawing.Point(179, 111);
            this.buttonCancelAddPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddPaymentType.Name = "buttonCancelAddPaymentType";
            this.buttonCancelAddPaymentType.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddPaymentType.TabIndex = 49;
            this.buttonCancelAddPaymentType.Text = "Отмена";
            this.buttonCancelAddPaymentType.UseVisualStyleBackColor = true;
            this.buttonCancelAddPaymentType.Click += new System.EventHandler(this.ButtonCancelAddPaymentType_Click);
            // 
            // buttonAddPaymentType
            // 
            this.buttonAddPaymentType.Location = new System.Drawing.Point(15, 111);
            this.buttonAddPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPaymentType.Name = "buttonAddPaymentType";
            this.buttonAddPaymentType.Size = new System.Drawing.Size(156, 47);
            this.buttonAddPaymentType.TabIndex = 48;
            this.buttonAddPaymentType.Text = "Добавить платеж ";
            this.buttonAddPaymentType.UseVisualStyleBackColor = true;
            this.buttonAddPaymentType.Click += new System.EventHandler(this.ButtonAddPaymentType_Click);
            // 
            // AddPayment_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPaymentCostInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPaymentNameInput);
            this.Controls.Add(this.buttonCancelAddPaymentType);
            this.Controls.Add(this.buttonAddPaymentType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPayment_Type";
            this.Text = "Добавление платежа";
            this.Load += new System.EventHandler(this.AddPaymentType_Load);
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