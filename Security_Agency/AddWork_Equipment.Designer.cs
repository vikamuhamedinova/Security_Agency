namespace Security_Agency
{
    partial class AddWork_Equipment
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInputNameWork = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddWork
            // 
            this.buttonAddWork.Location = new System.Drawing.Point(16, 347);
            this.buttonAddWork.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddWork.Name = "buttonAddWork";
            this.buttonAddWork.Size = new System.Drawing.Size(143, 43);
            this.buttonAddWork.TabIndex = 0;
            this.buttonAddWork.Text = "Добавить работу";
            this.buttonAddWork.UseVisualStyleBackColor = true;
            this.buttonAddWork.Click += new System.EventHandler(this.ButtonAddWorkEquip_Click);
            // 
            // checkBoxWorkDone
            // 
            this.checkBoxWorkDone.AutoSize = true;
            this.checkBoxWorkDone.Location = new System.Drawing.Point(12, 219);
            this.checkBoxWorkDone.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxWorkDone.Name = "checkBoxWorkDone";
            this.checkBoxWorkDone.Size = new System.Drawing.Size(155, 21);
            this.checkBoxWorkDone.TabIndex = 1;
            this.checkBoxWorkDone.Text = "Работа выполнена";
            this.checkBoxWorkDone.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(8, 175);
            this.comboBoxMaster.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(235, 24);
            this.comboBoxMaster.TabIndex = 3;
            // 
            // dateTimeInputPlanWork
            // 
            this.dateTimeInputPlanWork.CustomFormat = "00.00.0000";
            this.dateTimeInputPlanWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputPlanWork.Location = new System.Drawing.Point(8, 79);
            this.dateTimeInputPlanWork.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInputPlanWork.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputPlanWork.Name = "dateTimeInputPlanWork";
            this.dateTimeInputPlanWork.Size = new System.Drawing.Size(235, 22);
            this.dateTimeInputPlanWork.TabIndex = 26;
            this.dateTimeInputPlanWork.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Дата планируемого проведения работ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Дата проведения работ";
            // 
            // dateTimeInputWork
            // 
            this.dateTimeInputWork.CustomFormat = "00.00.0000";
            this.dateTimeInputWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputWork.Location = new System.Drawing.Point(8, 127);
            this.dateTimeInputWork.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInputWork.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputWork.Name = "dateTimeInputWork";
            this.dateTimeInputWork.Size = new System.Drawing.Size(235, 22);
            this.dateTimeInputWork.TabIndex = 29;
            this.dateTimeInputWork.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Мастер";
            // 
            // buttonCancelAddWork
            // 
            this.buttonCancelAddWork.Location = new System.Drawing.Point(167, 347);
            this.buttonCancelAddWork.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddWork.Name = "buttonCancelAddWork";
            this.buttonCancelAddWork.Size = new System.Drawing.Size(120, 43);
            this.buttonCancelAddWork.TabIndex = 31;
            this.buttonCancelAddWork.Text = "Отмена";
            this.buttonCancelAddWork.UseVisualStyleBackColor = true;
            this.buttonCancelAddWork.Click += new System.EventHandler(this.ButtonCancelAddWorkEquip_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Наименование работ";
            // 
            // textBoxInputNameWork
            // 
            this.textBoxInputNameWork.Location = new System.Drawing.Point(8, 34);
            this.textBoxInputNameWork.Name = "textBoxInputNameWork";
            this.textBoxInputNameWork.Size = new System.Drawing.Size(235, 22);
            this.textBoxInputNameWork.TabIndex = 34;
            // 
            // AddWork_Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 405);
            this.Controls.Add(this.textBoxInputNameWork);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelAddWork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeInputWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeInputPlanWork);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.checkBoxWorkDone);
            this.Controls.Add(this.buttonAddWork);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddWork_Equipment";
            this.Text = "Добавление работ";
            this.Load += new System.EventHandler(this.AddWorkEquip_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInputNameWork;
    }
}