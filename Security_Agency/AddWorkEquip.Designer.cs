namespace Security_Agency
{
    partial class AddWorkEquip
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
            this.buttonAddWork = new System.Windows.Forms.Button();
            this.checkBoxWorkDone = new System.Windows.Forms.CheckBox();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.dateTimeInputPlanWork = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeInputWork = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCancelAddWork = new System.Windows.Forms.Button();
            this.maskedTextBoxInputNumberWork = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Location = new System.Drawing.Point(12, 282);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(107, 35);
            this.buttonAddWork.TabIndex = 0;
            this.buttonAddWork.Text = "Добавить работу";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            // 
            // checkBoxWorkDone
            // 
            this.checkBoxWorkDone.AutoSize = true;
            this.checkBoxWorkDone.Location = new System.Drawing.Point(9, 178);
            this.checkBoxWorkDone.Name = "checkBoxWorkDone";
            this.checkBoxWorkDone.Size = new System.Drawing.Size(121, 17);
            this.checkBoxWorkDone.TabIndex = 1;
            this.checkBoxWorkDone.Text = "Работа выполнена";
            this.checkBoxWorkDone.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(6, 142);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(177, 21);
            this.comboBoxMaster.TabIndex = 3;
            // 
            // dateTimeInputPlanWork
            // 
            this.dateTimeInputPlanWork.CustomFormat = "00.00.0000";
            this.dateTimeInputPlanWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputPlanWork.Location = new System.Drawing.Point(6, 64);
            this.dateTimeInputPlanWork.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputPlanWork.Name = "dateTimeInputPlanWork";
            this.dateTimeInputPlanWork.Size = new System.Drawing.Size(177, 20);
            this.dateTimeInputPlanWork.TabIndex = 26;
            this.dateTimeInputPlanWork.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Дата планируемого проведения работ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Дата проведения работ";
            // 
            // dateTimeInputWork
            // 
            this.dateTimeInputWork.CustomFormat = "00.00.0000";
            this.dateTimeInputWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputWork.Location = new System.Drawing.Point(6, 103);
            this.dateTimeInputWork.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputWork.Name = "dateTimeInputWork";
            this.dateTimeInputWork.Size = new System.Drawing.Size(177, 20);
            this.dateTimeInputWork.TabIndex = 29;
            this.dateTimeInputWork.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Мастер";
            // 
            // buttonCancelAddWork
            // 
            this.buttonCancelAddWork.Location = new System.Drawing.Point(125, 282);
            this.buttonCancelAddWork.Name = "buttonCancelAddWork";
            this.buttonCancelAddWork.Size = new System.Drawing.Size(90, 35);
            this.buttonCancelAddWork.TabIndex = 31;
            this.buttonCancelAddWork.Text = "Отмена";
            this.buttonCancelAddWork.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxInputNumberWork
            // 
            this.maskedTextBoxInputNumberWork.Location = new System.Drawing.Point(6, 25);
            this.maskedTextBoxInputNumberWork.Mask = "00000";
            this.maskedTextBoxInputNumberWork.Name = "maskedTextBoxInputNumberWork";
            this.maskedTextBoxInputNumberWork.Size = new System.Drawing.Size(174, 20);
            this.maskedTextBoxInputNumberWork.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Номер работ";
            // 
            // AddWorkEquip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBoxInputNumberWork);
            this.Controls.Add(this.buttonCancelAddWork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeInputWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeInputPlanWork);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.checkBoxWorkDone);
            this.Controls.Add(this.buttonAddWork);
            this.Name = "AddWorkEquip";
            this.Text = "Добавление работ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddWork;
        private System.Windows.Forms.CheckBox checkBoxWorkDone;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.DateTimePicker dateTimeInputPlanWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeInputWork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCancelAddWork;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInputNumberWork;
        private System.Windows.Forms.Label label4;
    }
}