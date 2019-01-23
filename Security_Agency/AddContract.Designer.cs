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
            this.buttonAddApartment = new System.Windows.Forms.Button();
            this.dataGridViewProperty = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteWorkEquip = new System.Windows.Forms.Button();
            this.buttonAddWorkEquip = new System.Windows.Forms.Button();
            this.buttonEditWorkEquip = new System.Windows.Forms.Button();
            this.dataGridViewWorkEquip = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewResident = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperty)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResident)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddContract
            // 
            this.buttonAddContract.Location = new System.Drawing.Point(17, 278);
            this.buttonAddContract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddContract.Name = "buttonAddContract";
            this.buttonAddContract.Size = new System.Drawing.Size(149, 47);
            this.buttonAddContract.TabIndex = 0;
            this.buttonAddContract.Text = "Добавить договор";
            this.buttonAddContract.UseVisualStyleBackColor = true;
            this.buttonAddContract.Click += new System.EventHandler(this.ButtonAddContract_Click);
            // 
            // buttonCancelAddContract
            // 
            this.buttonCancelAddContract.Location = new System.Drawing.Point(1124, 385);
            this.buttonCancelAddContract.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddContract.Name = "buttonCancelAddContract";
            this.buttonCancelAddContract.Size = new System.Drawing.Size(105, 42);
            this.buttonCancelAddContract.TabIndex = 1;
            this.buttonCancelAddContract.Text = "Отмена";
            this.buttonCancelAddContract.UseVisualStyleBackColor = true;
            this.buttonCancelAddContract.Click += new System.EventHandler(this.ButtonCancelAddContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер договора";
            // 
            // comboBoxAddClient
            // 
            this.comboBoxAddClient.FormattingEnabled = true;
            this.comboBoxAddClient.Location = new System.Drawing.Point(17, 124);
            this.comboBoxAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddClient.Name = "comboBoxAddClient";
            this.comboBoxAddClient.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddClient.TabIndex = 4;
            // 
            // maskedTextBoxContractIdInput
            // 
            this.maskedTextBoxContractIdInput.Location = new System.Drawing.Point(16, 31);
            this.maskedTextBoxContractIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxContractIdInput.Mask = "00000";
            this.maskedTextBoxContractIdInput.Name = "maskedTextBoxContractIdInput";
            this.maskedTextBoxContractIdInput.Size = new System.Drawing.Size(235, 22);
            this.maskedTextBoxContractIdInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Квартира";
            // 
            // comboBoxAddApartment
            // 
            this.comboBoxAddApartment.FormattingEnabled = true;
            this.comboBoxAddApartment.Location = new System.Drawing.Point(17, 173);
            this.comboBoxAddApartment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddApartment.Name = "comboBoxAddApartment";
            this.comboBoxAddApartment.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddApartment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сотрудник";
            // 
            // comboBoxAddEmployee
            // 
            this.comboBoxAddEmployee.FormattingEnabled = true;
            this.comboBoxAddEmployee.Location = new System.Drawing.Point(17, 222);
            this.comboBoxAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddEmployee.Name = "comboBoxAddEmployee";
            this.comboBoxAddEmployee.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAddEmployee.TabIndex = 10;
            // 
            // dateTimeInputContract
            // 
            this.dateTimeInputContract.CustomFormat = "00.00.0000";
            this.dateTimeInputContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputContract.Location = new System.Drawing.Point(17, 78);
            this.dateTimeInputContract.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInputContract.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputContract.Name = "dateTimeInputContract";
            this.dateTimeInputContract.Size = new System.Drawing.Size(235, 22);
            this.dateTimeInputContract.TabIndex = 25;
            this.dateTimeInputContract.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Дата заключения";
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.Location = new System.Drawing.Point(275, 161);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(127, 47);
            this.buttonAddApartment.TabIndex = 27;
            this.buttonAddApartment.Text = "Добавить квартиру";
            this.buttonAddApartment.UseVisualStyleBackColor = true;
            this.buttonAddApartment.Click += new System.EventHandler(this.ButtonAddApartment_Click);
            // 
            // dataGridViewProperty
            // 
            this.dataGridViewProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperty.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewProperty.Name = "dataGridViewProperty";
            this.dataGridViewProperty.RowTemplate.Height = 24;
            this.dataGridViewProperty.Size = new System.Drawing.Size(789, 249);
            this.dataGridViewProperty.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 40;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonDeleteProperty_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 38;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonAddProperty_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 42);
            this.button3.TabIndex = 39;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonEditProperty_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewProperty);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Имущество";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 42);
            this.button4.TabIndex = 44;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonDeleteResident_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 266);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 42);
            this.button5.TabIndex = 42;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonAddResident_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(143, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 42);
            this.button6.TabIndex = 43;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonEditResident_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewResident);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проживающие";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(422, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 347);
            this.tabControl1.TabIndex = 43;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteWorkEquip);
            this.tabPage3.Controls.Add(this.buttonAddWorkEquip);
            this.tabPage3.Controls.Add(this.buttonEditWorkEquip);
            this.tabPage3.Controls.Add(this.dataGridViewWorkEquip);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(803, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Работы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteWorkEquip
            // 
            this.buttonDeleteWorkEquip.Location = new System.Drawing.Point(284, 270);
            this.buttonDeleteWorkEquip.Name = "buttonDeleteWorkEquip";
            this.buttonDeleteWorkEquip.Size = new System.Drawing.Size(130, 42);
            this.buttonDeleteWorkEquip.TabIndex = 47;
            this.buttonDeleteWorkEquip.Text = "Удалить";
            this.buttonDeleteWorkEquip.UseVisualStyleBackColor = true;
            this.buttonDeleteWorkEquip.Click += new System.EventHandler(this.ButtonDeleteWorkEquip_Click);
            // 
            // buttonAddWorkEquip
            // 
            this.buttonAddWorkEquip.Location = new System.Drawing.Point(12, 270);
            this.buttonAddWorkEquip.Name = "buttonAddWorkEquip";
            this.buttonAddWorkEquip.Size = new System.Drawing.Size(130, 42);
            this.buttonAddWorkEquip.TabIndex = 45;
            this.buttonAddWorkEquip.Text = "Добавить";
            this.buttonAddWorkEquip.UseVisualStyleBackColor = true;
            this.buttonAddWorkEquip.Click += new System.EventHandler(this.ButtonAddWorkEquip_Click);
            // 
            // buttonEditWorkEquip
            // 
            this.buttonEditWorkEquip.Location = new System.Drawing.Point(148, 270);
            this.buttonEditWorkEquip.Name = "buttonEditWorkEquip";
            this.buttonEditWorkEquip.Size = new System.Drawing.Size(130, 42);
            this.buttonEditWorkEquip.TabIndex = 46;
            this.buttonEditWorkEquip.Text = "Редактировать";
            this.buttonEditWorkEquip.UseVisualStyleBackColor = true;
            this.buttonEditWorkEquip.Click += new System.EventHandler(this.ButtonEditWorkEquip_Click);
            // 
            // dataGridViewWorkEquip
            // 
            this.dataGridViewWorkEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkEquip.Location = new System.Drawing.Point(12, 15);
            this.dataGridViewWorkEquip.Name = "dataGridViewWorkEquip";
            this.dataGridViewWorkEquip.RowTemplate.Height = 24;
            this.dataGridViewWorkEquip.Size = new System.Drawing.Size(777, 249);
            this.dataGridViewWorkEquip.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(998, 385);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 42);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridViewResident
            // 
            this.dataGridViewResident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResident.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewResident.Name = "dataGridViewResident";
            this.dataGridViewResident.RowTemplate.Height = 24;
            this.dataGridViewResident.Size = new System.Drawing.Size(789, 249);
            this.dataGridViewResident.TabIndex = 45;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 454);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonAddApartment);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddContract";
            this.Text = "Добавить договор";
            this.Load += new System.EventHandler(this.AddContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperty)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResident)).EndInit();
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
        private System.Windows.Forms.Button buttonAddApartment;
        private System.Windows.Forms.DataGridView dataGridViewProperty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDeleteWorkEquip;
        private System.Windows.Forms.Button buttonAddWorkEquip;
        private System.Windows.Forms.Button buttonEditWorkEquip;
        private System.Windows.Forms.DataGridView dataGridViewWorkEquip;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewResident;
    }
}