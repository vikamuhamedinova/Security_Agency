namespace Security_Agency
{
    partial class AddContract
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
            this.buttonAddContract = new System.Windows.Forms.Button();
            this.buttonCancelAddContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAddClient = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxContractIdInput = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAddApartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAddEmployee = new System.Windows.Forms.ComboBox();
            this.dateTimeInputContract = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(12, 215);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(82, 34);
            this.buttonAddContract.TabIndex = 0;
            this.buttonAddContract.Text = "Добавить договор";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAddContract
            // 
            this.buttonCancelAddContract.Location = new System.Drawing.Point(110, 215);
            this.buttonCancelAddContract.Name = "buttonCancelAddContract";
            this.buttonCancelAddContract.Size = new System.Drawing.Size(79, 34);
            this.buttonCancelAddContract.TabIndex = 1;
            this.buttonCancelAddContract.Text = "Отмена";
            this.buttonCancelAddContract.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер договора";
            // 
            // comboBoxAddClient
            // 
            this.comboBoxAddClient.FormattingEnabled = true;
            this.comboBoxAddClient.Location = new System.Drawing.Point(12, 64);
            this.comboBoxAddClient.Name = "comboBoxAddClient";
            this.comboBoxAddClient.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAddClient.TabIndex = 4;
            // 
            // maskedTextBoxContractIdInput
            // 
            this.maskedTextBoxContractIdInput.Location = new System.Drawing.Point(12, 25);
            this.maskedTextBoxContractIdInput.Mask = "00000";
            this.maskedTextBoxContractIdInput.Name = "maskedTextBoxContractIdInput";
            this.maskedTextBoxContractIdInput.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBoxContractIdInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Квартира";
            // 
            // comboBoxAddApartment
            // 
            this.comboBoxAddApartment.FormattingEnabled = true;
            this.comboBoxAddApartment.Location = new System.Drawing.Point(12, 104);
            this.comboBoxAddApartment.Name = "comboBoxAddApartment";
            this.comboBoxAddApartment.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAddApartment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сотрудник";
            // 
            // comboBoxAddEmployee
            // 
            this.comboBoxAddEmployee.FormattingEnabled = true;
            this.comboBoxAddEmployee.Location = new System.Drawing.Point(12, 144);
            this.comboBoxAddEmployee.Name = "comboBoxAddEmployee";
            this.comboBoxAddEmployee.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAddEmployee.TabIndex = 10;
            // 
            // dateTimeInputContract
            // 
            this.dateTimeInputContract.CustomFormat = "00.00.0000";
            this.dateTimeInputContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputContract.Location = new System.Drawing.Point(12, 184);
            this.dateTimeInputContract.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputContract.Name = "dateTimeInputContract";
            this.dateTimeInputContract.Size = new System.Drawing.Size(177, 20);
            this.dateTimeInputContract.TabIndex = 25;
            this.dateTimeInputContract.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата заключения";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeInputContract);
            this.Controls.Add(this.comboBoxAddEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAddApartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxContractIdInput);
            this.Controls.Add(this.comboBoxAddClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelAddContract);
            this.Controls.Add(this.buttonAddContract);
            this.Name = "AddContract";
            this.Text = "Добавить договор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddContract;
        private System.Windows.Forms.Button buttonCancelAddContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAddClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxContractIdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAddApartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAddEmployee;
        private System.Windows.Forms.DateTimePicker dateTimeInputContract;
        private System.Windows.Forms.Label label5;
    }
}