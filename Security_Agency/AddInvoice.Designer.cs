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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxAddPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddPayment = new System.Windows.Forms.Button();
            this.groupBoxPayments = new System.Windows.Forms.GroupBox();
            this.buttonDeletePayment = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonAddDefrayal = new System.Windows.Forms.Button();
            this.buttonEditDefrayal = new System.Windows.Forms.Button();
            this.buttonDeleteDefrayal = new System.Windows.Forms.Button();
            this.groupBoxDefrayal = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelDefrayalSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.groupBoxPayments.SuspendLayout();
            this.groupBoxDefrayal.SuspendLayout();
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
            this.buttonCancelAddInvoice.Location = new System.Drawing.Point(1158, 409);
            this.buttonCancelAddInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddInvoice.Name = "buttonCancelAddInvoice";
            this.buttonCancelAddInvoice.Size = new System.Drawing.Size(125, 42);
            this.buttonCancelAddInvoice.TabIndex = 28;
            this.buttonCancelAddInvoice.Text = "Отмена";
            this.buttonCancelAddInvoice.UseVisualStyleBackColor = true;
            this.buttonCancelAddInvoice.Click += new System.EventHandler(this.ButtonCancelAddInvoice_Click);
            // 
            // buttonAddInvoice
            // 
            this.buttonAddInvoice.Location = new System.Drawing.Point(11, 221);
            this.buttonAddInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddInvoice.Name = "buttonAddInvoice";
            this.buttonAddInvoice.Size = new System.Drawing.Size(125, 42);
            this.buttonAddInvoice.TabIndex = 27;
            this.buttonAddInvoice.Text = "Добавить счет";
            this.buttonAddInvoice.UseVisualStyleBackColor = true;
            this.buttonAddInvoice.Click += new System.EventHandler(this.ButtonAddInvoice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Итого:";
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(20, 21);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(625, 178);
            this.dataGridViewPayments.TabIndex = 45;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Штраф",
            "Платеж"});
            this.comboBoxType.Location = new System.Drawing.Point(708, 61);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(235, 24);
            this.comboBoxType.TabIndex = 46;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // comboBoxAddPayment
            // 
            this.comboBoxAddPayment.FormattingEnabled = true;
            this.comboBoxAddPayment.Location = new System.Drawing.Point(708, 116);
            this.comboBoxAddPayment.Name = "comboBoxAddPayment";
            this.comboBoxAddPayment.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddPayment.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(796, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Тип";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 49;
            this.label9.Text = "Вид";
            // 
            // buttonAddPayment
            // 
            this.buttonAddPayment.Location = new System.Drawing.Point(704, 157);
            this.buttonAddPayment.Name = "buttonAddPayment";
            this.buttonAddPayment.Size = new System.Drawing.Size(125, 42);
            this.buttonAddPayment.TabIndex = 50;
            this.buttonAddPayment.Text = "Добавить";
            this.buttonAddPayment.UseVisualStyleBackColor = true;
            this.buttonAddPayment.Click += new System.EventHandler(this.buttonAddPayment_Click);
            // 
            // groupBoxPayments
            // 
            this.groupBoxPayments.Controls.Add(this.buttonDeletePayment);
            this.groupBoxPayments.Controls.Add(this.label8);
            this.groupBoxPayments.Controls.Add(this.buttonAddPayment);
            this.groupBoxPayments.Controls.Add(this.comboBoxType);
            this.groupBoxPayments.Controls.Add(this.label9);
            this.groupBoxPayments.Controls.Add(this.labelSum);
            this.groupBoxPayments.Controls.Add(this.comboBoxAddPayment);
            this.groupBoxPayments.Controls.Add(this.dataGridViewPayments);
            this.groupBoxPayments.Controls.Add(this.label3);
            this.groupBoxPayments.Location = new System.Drawing.Point(298, 12);
            this.groupBoxPayments.Name = "groupBoxPayments";
            this.groupBoxPayments.Size = new System.Drawing.Size(993, 258);
            this.groupBoxPayments.TabIndex = 51;
            this.groupBoxPayments.TabStop = false;
            this.groupBoxPayments.Text = "Платежи";
            // 
            // buttonDeletePayment
            // 
            this.buttonDeletePayment.Location = new System.Drawing.Point(835, 157);
            this.buttonDeletePayment.Name = "buttonDeletePayment";
            this.buttonDeletePayment.Size = new System.Drawing.Size(125, 42);
            this.buttonDeletePayment.TabIndex = 51;
            this.buttonDeletePayment.Text = "Удалить";
            this.buttonDeletePayment.UseVisualStyleBackColor = true;
            this.buttonDeletePayment.Click += new System.EventHandler(this.buttonDeletePayment_Click);
            // 
            // labelSum
            // 
            this.labelSum.Location = new System.Drawing.Point(80, 222);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(100, 17);
            this.labelSum.TabIndex = 52;
            this.labelSum.Text = "00.00";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1004, 409);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 42);
            this.buttonSave.TabIndex = 51;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(25, 59);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(46, 17);
            this.labelStatus.TabIndex = 53;
            this.labelStatus.Text = "label6";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(150, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 17);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "label7";
            // 
            // buttonAddDefrayal
            // 
            this.buttonAddDefrayal.Location = new System.Drawing.Point(22, 91);
            this.buttonAddDefrayal.Name = "buttonAddDefrayal";
            this.buttonAddDefrayal.Size = new System.Drawing.Size(125, 42);
            this.buttonAddDefrayal.TabIndex = 55;
            this.buttonAddDefrayal.Text = "Добавить";
            this.buttonAddDefrayal.UseVisualStyleBackColor = true;
            this.buttonAddDefrayal.Click += new System.EventHandler(this.buttonAddDefrayal_Click);
            // 
            // buttonEditDefrayal
            // 
            this.buttonEditDefrayal.Location = new System.Drawing.Point(153, 91);
            this.buttonEditDefrayal.Name = "buttonEditDefrayal";
            this.buttonEditDefrayal.Size = new System.Drawing.Size(125, 42);
            this.buttonEditDefrayal.TabIndex = 56;
            this.buttonEditDefrayal.Text = "Редактировать";
            this.buttonEditDefrayal.UseVisualStyleBackColor = true;
            this.buttonEditDefrayal.Click += new System.EventHandler(this.buttonEditDefrayal_Click);
            // 
            // buttonDeleteDefrayal
            // 
            this.buttonDeleteDefrayal.Location = new System.Drawing.Point(284, 91);
            this.buttonDeleteDefrayal.Name = "buttonDeleteDefrayal";
            this.buttonDeleteDefrayal.Size = new System.Drawing.Size(125, 42);
            this.buttonDeleteDefrayal.TabIndex = 57;
            this.buttonDeleteDefrayal.Text = "Удалить";
            this.buttonDeleteDefrayal.UseVisualStyleBackColor = true;
            this.buttonDeleteDefrayal.Click += new System.EventHandler(this.buttonDeleteDefrayal_Click);
            // 
            // groupBoxDefrayal
            // 
            this.groupBoxDefrayal.Controls.Add(this.label13);
            this.groupBoxDefrayal.Controls.Add(this.label12);
            this.groupBoxDefrayal.Controls.Add(this.label11);
            this.groupBoxDefrayal.Controls.Add(this.labelDefrayalSum);
            this.groupBoxDefrayal.Controls.Add(this.buttonAddDefrayal);
            this.groupBoxDefrayal.Controls.Add(this.labelDate);
            this.groupBoxDefrayal.Controls.Add(this.labelStatus);
            this.groupBoxDefrayal.Controls.Add(this.buttonDeleteDefrayal);
            this.groupBoxDefrayal.Controls.Add(this.buttonEditDefrayal);
            this.groupBoxDefrayal.Location = new System.Drawing.Point(12, 296);
            this.groupBoxDefrayal.Name = "groupBoxDefrayal";
            this.groupBoxDefrayal.Size = new System.Drawing.Size(428, 155);
            this.groupBoxDefrayal.TabIndex = 58;
            this.groupBoxDefrayal.TabStop = false;
            this.groupBoxDefrayal.Text = "Оплата";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Сумма";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 60;
            this.label12.Text = "Дата оплаты";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Статус";
            // 
            // labelDefrayalSum
            // 
            this.labelDefrayalSum.AutoSize = true;
            this.labelDefrayalSum.Location = new System.Drawing.Point(281, 59);
            this.labelDefrayalSum.Name = "labelDefrayalSum";
            this.labelDefrayalSum.Size = new System.Drawing.Size(54, 17);
            this.labelDefrayalSum.TabIndex = 58;
            this.labelDefrayalSum.Text = "label10";
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 480);
            this.Controls.Add(this.groupBoxDefrayal);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxPayments);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.groupBoxPayments.ResumeLayout(false);
            this.groupBoxPayments.PerformLayout();
            this.groupBoxDefrayal.ResumeLayout(false);
            this.groupBoxDefrayal.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxAddPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddPayment;
        private System.Windows.Forms.GroupBox groupBoxPayments;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDeletePayment;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAddDefrayal;
        private System.Windows.Forms.Button buttonEditDefrayal;
        private System.Windows.Forms.Button buttonDeleteDefrayal;
        private System.Windows.Forms.GroupBox groupBoxDefrayal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelDefrayalSum;
    }
}