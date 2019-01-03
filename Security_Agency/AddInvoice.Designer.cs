namespace Security_Agency
{
    partial class AddInvoice
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
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeInvoiceInput = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAddEmployee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxInvoiceIdInput = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxAddContract = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelAddInvoice = new System.Windows.Forms.Button();
            this.buttonAddInvoice = new System.Windows.Forms.Button();
            this.maskedTextBoxInpSum = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBoxForfeitType = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxPaymentType = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Дата формирования";
            // 
            // dateTimeInvoiceInput
            // 
            this.dateTimeInvoiceInput.CustomFormat = "00.00.0000";
            this.dateTimeInvoiceInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInvoiceInput.Location = new System.Drawing.Point(11, 128);
            this.dateTimeInvoiceInput.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInvoiceInput.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInvoiceInput.Name = "dateTimeInvoiceInput";
            this.dateTimeInvoiceInput.Size = new System.Drawing.Size(235, 22);
            this.dateTimeInvoiceInput.TabIndex = 37;
            this.dateTimeInvoiceInput.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // comboBoxAddEmployee
            // 
            this.comboBoxAddEmployee.FormattingEnabled = true;
            this.comboBoxAddEmployee.Location = new System.Drawing.Point(11, 175);
            this.comboBoxAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddEmployee.Name = "comboBoxAddEmployee";
            this.comboBoxAddEmployee.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddEmployee.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Сотрудник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Договор";
            // 
            // maskedTextBoxInvoiceIdInput
            // 
            this.maskedTextBoxInvoiceIdInput.Location = new System.Drawing.Point(11, 80);
            this.maskedTextBoxInvoiceIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxInvoiceIdInput.Mask = "00000";
            this.maskedTextBoxInvoiceIdInput.Name = "maskedTextBoxInvoiceIdInput";
            this.maskedTextBoxInvoiceIdInput.Size = new System.Drawing.Size(235, 22);
            this.maskedTextBoxInvoiceIdInput.TabIndex = 31;
            // 
            // comboBoxAddContract
            // 
            this.comboBoxAddContract.FormattingEnabled = true;
            this.comboBoxAddContract.Location = new System.Drawing.Point(11, 31);
            this.comboBoxAddContract.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddContract.Name = "comboBoxAddContract";
            this.comboBoxAddContract.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddContract.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Номер счета";
            // 
            // buttonCancelAddInvoice
            // 
            this.buttonCancelAddInvoice.Location = new System.Drawing.Point(223, 396);
            this.buttonCancelAddInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddInvoice.Name = "buttonCancelAddInvoice";
            this.buttonCancelAddInvoice.Size = new System.Drawing.Size(105, 42);
            this.buttonCancelAddInvoice.TabIndex = 28;
            this.buttonCancelAddInvoice.Text = "Отмена";
            this.buttonCancelAddInvoice.UseVisualStyleBackColor = true;
            this.buttonCancelAddInvoice.Click += new System.EventHandler(this.ButtonCancelAddInvoice_Click);
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.Location = new System.Drawing.Point(11, 396);
            this.buttonAddInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(109, 42);
            this.buttonAddInvoice.TabIndex = 27;
            this.buttonAddInvoice.Text = "Добавить счет";
            this.buttonAddInvoice.UseVisualStyleBackColor = true;
            this.buttonAddInvoice.Click += new System.EventHandler(this.ButtonAddInvoice_Click);
            // 
            // maskedTextBoxInpSum
            // 
            this.maskedTextBoxInpSum.Location = new System.Drawing.Point(11, 355);
            this.maskedTextBoxInpSum.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxInpSum.Mask = "00000000000";
            this.maskedTextBoxInpSum.Name = "maskedTextBoxInpSum";
            this.maskedTextBoxInpSum.Size = new System.Drawing.Size(235, 22);
            this.maskedTextBoxInpSum.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Сумма";
            // 
            // checkedListBoxForfeitType
            // 
            this.checkedListBoxForfeitType.FormattingEnabled = true;
            this.checkedListBoxForfeitType.Location = new System.Drawing.Point(11, 224);
            this.checkedListBoxForfeitType.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxForfeitType.Name = "checkedListBoxForfeitType";
            this.checkedListBoxForfeitType.Size = new System.Drawing.Size(219, 106);
            this.checkedListBoxForfeitType.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Штрафы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Услуги";
            // 
            // checkedListBoxPaymentType
            // 
            this.checkedListBoxPaymentType.FormattingEnabled = true;
            this.checkedListBoxPaymentType.Location = new System.Drawing.Point(251, 224);
            this.checkedListBoxPaymentType.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxPaymentType.Name = "checkedListBoxPaymentType";
            this.checkedListBoxPaymentType.Size = new System.Drawing.Size(224, 106);
            this.checkedListBoxPaymentType.TabIndex = 43;
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkedListBoxPaymentType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBoxForfeitType);
            this.Controls.Add(this.maskedTextBoxInpSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeInvoiceInput);
            this.Controls.Add(this.comboBoxAddEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxInvoiceIdInput);
            this.Controls.Add(this.comboBoxAddContract);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelAddInvoice);
            this.Controls.Add(this.buttonAddInvoice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddInvoice";
            this.Text = "Добавление счета";
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            this.Click += new System.EventHandler(this.AddInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeInvoiceInput;
        private System.Windows.Forms.ComboBox comboBoxAddEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInvoiceIdInput;
        private System.Windows.Forms.ComboBox comboBoxAddContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelAddInvoice;
        private System.Windows.Forms.Button buttonAddInvoice;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInpSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBoxForfeitType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxPaymentType;
    }
}