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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHackSign = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.dataGridViewStolenObj = new System.Windows.Forms.DataGridView();
            this.buttonCancelAddCall = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddDetainPers = new System.Windows.Forms.Button();
            this.buttonEditDetainPers = new System.Windows.Forms.Button();
            this.buttonDeleteDetainPers = new System.Windows.Forms.Button();
            this.buttonAddStolenObj = new System.Windows.Forms.Button();
            this.buttonEditStolenObj = new System.Windows.Forms.Button();
            this.buttonDeleteStolenObj = new System.Windows.Forms.Button();
            this.maskedTextBoxPickerTimeCall = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPickerTimeArrive = new System.Windows.Forms.MaskedTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStolenObj)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddCall
            // 
            this.buttonAddCall.Location = new System.Drawing.Point(16, 251);
            this.buttonAddCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCall.Name = "buttonAddCall";
            this.buttonAddCall.Size = new System.Drawing.Size(171, 47);
            this.buttonAddCall.TabIndex = 1;
            this.buttonAddCall.Text = "Добавить вызов";
            this.buttonAddCall.UseVisualStyleBackColor = true;
            this.buttonAddCall.Click += new System.EventHandler(this.ButtonAddCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата вызова";
            // 
            // dataGridViewDetainPers
            // 
            this.dataGridViewDetainPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetainPers.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewDetainPers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDetainPers.Name = "dataGridViewDetainPers";
            this.dataGridViewDetainPers.Size = new System.Drawing.Size(623, 185);
            this.dataGridViewDetainPers.TabIndex = 3;
            // 
            // checkBoxFalseCall
            // 
            this.checkBoxFalseCall.AutoSize = true;
            this.checkBoxFalseCall.Location = new System.Drawing.Point(16, 176);
            this.checkBoxFalseCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxFalseCall.Name = "checkBoxFalseCall";
            this.checkBoxFalseCall.Size = new System.Drawing.Size(126, 21);
            this.checkBoxFalseCall.TabIndex = 4;
            this.checkBoxFalseCall.Text = "Ложный вызов";
            this.checkBoxFalseCall.UseVisualStyleBackColor = true;
            this.checkBoxFalseCall.CheckedChanged += new System.EventHandler(this.CheckBoxFalseCall_CheckedChanged);
            // 
            // comboBoxApartment
            // 
            this.comboBoxApartment.FormattingEnabled = true;
            this.comboBoxApartment.Location = new System.Drawing.Point(279, 31);
            this.comboBoxApartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxApartment.Name = "comboBoxApartment";
            this.comboBoxApartment.Size = new System.Drawing.Size(160, 24);
            this.comboBoxApartment.TabIndex = 5;
            // 
            // dateTimeInputDateCall
            // 
            this.dateTimeInputDateCall.CustomFormat = "00.00.0000";
            this.dateTimeInputDateCall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputDateCall.Location = new System.Drawing.Point(16, 31);
            this.dateTimeInputDateCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputDateCall.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputDateCall.Name = "dateTimeInputDateCall";
            this.dateTimeInputDateCall.Size = new System.Drawing.Size(220, 22);
            this.dateTimeInputDateCall.TabIndex = 11;
            this.dateTimeInputDateCall.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время вызова";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Время прибытия";
            // 
            // checkBoxHackSign
            // 
            this.checkBoxHackSign.AutoSize = true;
            this.checkBoxHackSign.Location = new System.Drawing.Point(16, 204);
            this.checkBoxHackSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHackSign.Name = "checkBoxHackSign";
            this.checkBoxHackSign.Size = new System.Drawing.Size(145, 21);
            this.checkBoxHackSign.TabIndex = 16;
            this.checkBoxHackSign.Text = "Признаки взлома";
            this.checkBoxHackSign.UseVisualStyleBackColor = true;
            this.checkBoxHackSign.CheckedChanged += new System.EventHandler(this.CheckBoxHackSign_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Квартира";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(279, 79);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEmployee.TabIndex = 18;
            // 
            // dataGridViewStolenObj
            // 
            this.dataGridViewStolenObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStolenObj.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewStolenObj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewStolenObj.Name = "dataGridViewStolenObj";
            this.dataGridViewStolenObj.Size = new System.Drawing.Size(623, 185);
            this.dataGridViewStolenObj.TabIndex = 21;
            // 
            // buttonCancelAddCall
            // 
            this.buttonCancelAddCall.Location = new System.Drawing.Point(960, 309);
            this.buttonCancelAddCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddCall.Name = "buttonCancelAddCall";
            this.buttonCancelAddCall.Size = new System.Drawing.Size(171, 47);
            this.buttonCancelAddCall.TabIndex = 23;
            this.buttonCancelAddCall.Text = "Отмена";
            this.buttonCancelAddCall.UseVisualStyleBackColor = true;
            this.buttonCancelAddCall.Click += new System.EventHandler(this.ButtonCancelAddCall_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(486, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 288);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeleteDetainPers);
            this.tabPage1.Controls.Add(this.buttonEditDetainPers);
            this.tabPage1.Controls.Add(this.buttonAddDetainPers);
            this.tabPage1.Controls.Add(this.dataGridViewDetainPers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(637, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задержанные лица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteStolenObj);
            this.tabPage2.Controls.Add(this.buttonEditStolenObj);
            this.tabPage2.Controls.Add(this.buttonAddStolenObj);
            this.tabPage2.Controls.Add(this.dataGridViewStolenObj);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(637, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Украденные вещи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddDetainPers
            // 
            this.buttonAddDetainPers.Location = new System.Drawing.Point(7, 206);
            this.buttonAddDetainPers.Name = "buttonAddDetainPers";
            this.buttonAddDetainPers.Size = new System.Drawing.Size(128, 37);
            this.buttonAddDetainPers.TabIndex = 4;
            this.buttonAddDetainPers.Text = "Добавить";
            this.buttonAddDetainPers.UseVisualStyleBackColor = true;
            this.buttonAddDetainPers.Click += new System.EventHandler(this.ButtonAddDetainPers_Click);
            // 
            // buttonEditDetainPers
            // 
            this.buttonEditDetainPers.Location = new System.Drawing.Point(141, 206);
            this.buttonEditDetainPers.Name = "buttonEditDetainPers";
            this.buttonEditDetainPers.Size = new System.Drawing.Size(128, 37);
            this.buttonEditDetainPers.TabIndex = 5;
            this.buttonEditDetainPers.Text = "Редактировать";
            this.buttonEditDetainPers.UseVisualStyleBackColor = true;
            this.buttonEditDetainPers.Click += new System.EventHandler(this.ButtonEditDetainPers_Click);
            // 
            // buttonDeleteDetainPers
            // 
            this.buttonDeleteDetainPers.Location = new System.Drawing.Point(275, 206);
            this.buttonDeleteDetainPers.Name = "buttonDeleteDetainPers";
            this.buttonDeleteDetainPers.Size = new System.Drawing.Size(128, 37);
            this.buttonDeleteDetainPers.TabIndex = 6;
            this.buttonDeleteDetainPers.Text = "Удалить";
            this.buttonDeleteDetainPers.UseVisualStyleBackColor = true;
            this.buttonDeleteDetainPers.Click += new System.EventHandler(this.ButtonDeleteDetainPers_Click);
            // 
            // buttonAddStolenObj
            // 
            this.buttonAddStolenObj.Location = new System.Drawing.Point(7, 206);
            this.buttonAddStolenObj.Name = "buttonAddStolenObj";
            this.buttonAddStolenObj.Size = new System.Drawing.Size(128, 37);
            this.buttonAddStolenObj.TabIndex = 22;
            this.buttonAddStolenObj.Text = "Добавить";
            this.buttonAddStolenObj.UseVisualStyleBackColor = true;
            this.buttonAddStolenObj.Click += new System.EventHandler(this.ButtonAddStolenObj_Click);
            // 
            // buttonEditStolenObj
            // 
            this.buttonEditStolenObj.Location = new System.Drawing.Point(141, 206);
            this.buttonEditStolenObj.Name = "buttonEditStolenObj";
            this.buttonEditStolenObj.Size = new System.Drawing.Size(128, 37);
            this.buttonEditStolenObj.TabIndex = 23;
            this.buttonEditStolenObj.Text = "Редактировать";
            this.buttonEditStolenObj.UseVisualStyleBackColor = true;
            this.buttonEditStolenObj.Click += new System.EventHandler(this.ButtonEditStolenObj_Click);
            // 
            // buttonDeleteStolenObj
            // 
            this.buttonDeleteStolenObj.Location = new System.Drawing.Point(278, 206);
            this.buttonDeleteStolenObj.Name = "buttonDeleteStolenObj";
            this.buttonDeleteStolenObj.Size = new System.Drawing.Size(128, 37);
            this.buttonDeleteStolenObj.TabIndex = 24;
            this.buttonDeleteStolenObj.Text = "Удалить";
            this.buttonDeleteStolenObj.UseVisualStyleBackColor = true;
            this.buttonDeleteStolenObj.Click += new System.EventHandler(this.ButtonDeleteStolenObj_Click);
            // 
            // maskedTextBoxPickerTimeCall
            // 
            this.maskedTextBoxPickerTimeCall.Location = new System.Drawing.Point(16, 79);
            this.maskedTextBoxPickerTimeCall.Mask = "00:00";
            this.maskedTextBoxPickerTimeCall.Name = "maskedTextBoxPickerTimeCall";
            this.maskedTextBoxPickerTimeCall.Size = new System.Drawing.Size(220, 22);
            this.maskedTextBoxPickerTimeCall.TabIndex = 25;
            this.maskedTextBoxPickerTimeCall.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxPickerTimeArrive
            // 
            this.maskedTextBoxPickerTimeArrive.Location = new System.Drawing.Point(16, 127);
            this.maskedTextBoxPickerTimeArrive.Mask = "00:00";
            this.maskedTextBoxPickerTimeArrive.Name = "maskedTextBoxPickerTimeArrive";
            this.maskedTextBoxPickerTimeArrive.Size = new System.Drawing.Size(220, 22);
            this.maskedTextBoxPickerTimeArrive.TabIndex = 26;
            this.maskedTextBoxPickerTimeArrive.ValidatingType = typeof(System.DateTime);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(782, 311);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(171, 47);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 370);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.maskedTextBoxPickerTimeArrive);
            this.Controls.Add(this.maskedTextBoxPickerTimeCall);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancelAddCall);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxHackSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeInputDateCall);
            this.Controls.Add(this.comboBoxApartment);
            this.Controls.Add(this.checkBoxFalseCall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCall);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCall";
            this.Text = "Добавить вызв";
            this.Load += new System.EventHandler(this.AddCall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStolenObj)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHackSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.DataGridView dataGridViewStolenObj;
        private System.Windows.Forms.Button buttonCancelAddCall;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDeleteDetainPers;
        private System.Windows.Forms.Button buttonEditDetainPers;
        private System.Windows.Forms.Button buttonAddDetainPers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDeleteStolenObj;
        private System.Windows.Forms.Button buttonEditStolenObj;
        private System.Windows.Forms.Button buttonAddStolenObj;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPickerTimeCall;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPickerTimeArrive;
        private System.Windows.Forms.Button buttonSave;
    }
}