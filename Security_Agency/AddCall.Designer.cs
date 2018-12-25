namespace Security_Agency
{
    partial class AddCall
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
            this.buttonAddCall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDetainPers = new System.Windows.Forms.DataGridView();
            this.checkBoxFalseCall = new System.Windows.Forms.CheckBox();
            this.comboBoxApartment = new System.Windows.Forms.ComboBox();
            this.dateTimeInputDateCall = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTimeCall = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTimeArrive = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHackSign = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewStolenObj = new System.Windows.Forms.DataGridView();
            this.buttonCancelAddCall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStolenObj)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCall
            // 
            this.buttonAddCall.Location = new System.Drawing.Point(576, 251);
            this.buttonAddCall.Name = "buttonAddCall";
            this.buttonAddCall.Size = new System.Drawing.Size(128, 38);
            this.buttonAddCall.TabIndex = 1;
            this.buttonAddCall.Text = "Добавить вызов";
            this.buttonAddCall.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата вызова";
            // 
            // dataGridViewDetainPers
            // 
            this.dataGridViewDetainPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetainPers.Location = new System.Drawing.Point(362, 25);
            this.dataGridViewDetainPers.Name = "dataGridViewDetainPers";
            this.dataGridViewDetainPers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDetainPers.TabIndex = 3;
            // 
            // checkBoxFalseCall
            // 
            this.checkBoxFalseCall.AutoSize = true;
            this.checkBoxFalseCall.Location = new System.Drawing.Point(12, 143);
            this.checkBoxFalseCall.Name = "checkBoxFalseCall";
            this.checkBoxFalseCall.Size = new System.Drawing.Size(103, 17);
            this.checkBoxFalseCall.TabIndex = 4;
            this.checkBoxFalseCall.Text = "Ложный вызов";
            this.checkBoxFalseCall.UseVisualStyleBackColor = true;
            // 
            // comboBoxApartment
            // 
            this.comboBoxApartment.FormattingEnabled = true;
            this.comboBoxApartment.Location = new System.Drawing.Point(209, 25);
            this.comboBoxApartment.Name = "comboBoxApartment";
            this.comboBoxApartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApartment.TabIndex = 5;
            // 
            // dateTimeInputDateCall
            // 
            this.dateTimeInputDateCall.CustomFormat = "00.00.0000";
            this.dateTimeInputDateCall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputDateCall.Location = new System.Drawing.Point(12, 25);
            this.dateTimeInputDateCall.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputDateCall.Name = "dateTimeInputDateCall";
            this.dateTimeInputDateCall.Size = new System.Drawing.Size(166, 20);
            this.dateTimeInputDateCall.TabIndex = 11;
            this.dateTimeInputDateCall.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // dateTimePickerTimeCall
            // 
            this.dateTimePickerTimeCall.CustomFormat = "00:00";
            this.dateTimePickerTimeCall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTimeCall.Location = new System.Drawing.Point(12, 64);
            this.dateTimePickerTimeCall.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTimeCall.Name = "dateTimePickerTimeCall";
            this.dateTimePickerTimeCall.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTimeCall.TabIndex = 13;
            this.dateTimePickerTimeCall.Value = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время вызова";
            // 
            // dateTimePickerTimeArrive
            // 
            this.dateTimePickerTimeArrive.CustomFormat = "00:00";
            this.dateTimePickerTimeArrive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTimeArrive.Location = new System.Drawing.Point(12, 103);
            this.dateTimePickerTimeArrive.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTimeArrive.Name = "dateTimePickerTimeArrive";
            this.dateTimePickerTimeArrive.Size = new System.Drawing.Size(166, 20);
            this.dateTimePickerTimeArrive.TabIndex = 15;
            this.dateTimePickerTimeArrive.Value = new System.DateTime(2018, 12, 26, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Время прибытия";
            // 
            // checkBoxHackSign
            // 
            this.checkBoxHackSign.AutoSize = true;
            this.checkBoxHackSign.Location = new System.Drawing.Point(12, 166);
            this.checkBoxHackSign.Name = "checkBoxHackSign";
            this.checkBoxHackSign.Size = new System.Drawing.Size(117, 17);
            this.checkBoxHackSign.TabIndex = 16;
            this.checkBoxHackSign.Text = "Признаки взлома";
            this.checkBoxHackSign.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Квартира";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(209, 64);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmployee.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Задержанные лица";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Украденные вещи";
            // 
            // dataGridViewStolenObj
            // 
            this.dataGridViewStolenObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStolenObj.Location = new System.Drawing.Point(608, 25);
            this.dataGridViewStolenObj.Name = "dataGridViewStolenObj";
            this.dataGridViewStolenObj.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewStolenObj.TabIndex = 21;
            // 
            // buttonCancelAddCall
            // 
            this.buttonCancelAddCall.Location = new System.Drawing.Point(720, 251);
            this.buttonCancelAddCall.Name = "buttonCancelAddCall";
            this.buttonCancelAddCall.Size = new System.Drawing.Size(128, 38);
            this.buttonCancelAddCall.TabIndex = 23;
            this.buttonCancelAddCall.Text = "Отмена";
            this.buttonCancelAddCall.UseVisualStyleBackColor = true;
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 301);
            this.Controls.Add(this.buttonCancelAddCall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewStolenObj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxHackSign);
            this.Controls.Add(this.dateTimePickerTimeArrive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTimeCall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeInputDateCall);
            this.Controls.Add(this.comboBoxApartment);
            this.Controls.Add(this.checkBoxFalseCall);
            this.Controls.Add(this.dataGridViewDetainPers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCall);
            this.Name = "AddCall";
            this.Text = "Добавить вызв";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStolenObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetainPers;
        private System.Windows.Forms.CheckBox checkBoxFalseCall;
        private System.Windows.Forms.ComboBox comboBoxApartment;
        private System.Windows.Forms.DateTimePicker dateTimeInputDateCall;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeArrive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHackSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewStolenObj;
        private System.Windows.Forms.Button buttonCancelAddCall;
    }
}