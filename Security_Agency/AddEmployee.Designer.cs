namespace Security_Agency
{
    partial class AddEmployee
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
            this.maskedtextBoxInputPassID = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelAddEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelInputPassID = new System.Windows.Forms.Label();
            this.textBoxMiddleNameInput = new System.Windows.Forms.TextBox();
            this.labelInputMiddlName = new System.Windows.Forms.Label();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxSurnameInput = new System.Windows.Forms.TextBox();
            this.maskedTextBoxInputINN = new System.Windows.Forms.MaskedTextBox();
            this.labelInputINN = new System.Windows.Forms.Label();
            this.comboBoxInputPosition = new System.Windows.Forms.ComboBox();
            this.labelInputPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedtextBoxInputPassID
            // 
            this.maskedtextBoxInputPassID.Location = new System.Drawing.Point(16, 187);
            this.maskedtextBoxInputPassID.Margin = new System.Windows.Forms.Padding(4);
            this.maskedtextBoxInputPassID.Mask = "0000000000";
            this.maskedtextBoxInputPassID.Name = "maskedtextBoxInputPassID";
            this.maskedtextBoxInputPassID.Size = new System.Drawing.Size(301, 22);
            this.maskedtextBoxInputPassID.TabIndex = 28;
            // 
            // buttonCancelAddEmployee
            // 
            this.buttonCancelAddEmployee.Location = new System.Drawing.Point(180, 320);
            this.buttonCancelAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddEmployee.Name = "buttonCancelAddEmployee";
            this.buttonCancelAddEmployee.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddEmployee.TabIndex = 27;
            this.buttonCancelAddEmployee.Text = "Отмена";
            this.buttonCancelAddEmployee.UseVisualStyleBackColor = true;
            this.buttonCancelAddEmployee.Click += new System.EventHandler(this.ButtonCancelAddEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(16, 320);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(156, 47);
            this.buttonAddEmployee.TabIndex = 26;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(123, 167);
            this.labelInputPassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(117, 17);
            this.labelInputPassID.TabIndex = 21;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(16, 139);
            this.textBoxMiddleNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxMiddleNameInput.TabIndex = 20;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(123, 119);
            this.labelInputMiddlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(71, 17);
            this.labelInputMiddlName.TabIndex = 19;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(16, 91);
            this.textBoxNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxNameInput.TabIndex = 18;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(123, 71);
            this.labelNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(35, 17);
            this.labelNameInput.TabIndex = 17;
            this.labelNameInput.Text = "Имя";
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(123, 23);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(70, 17);
            this.labelSurnameInput.TabIndex = 16;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(16, 43);
            this.textBoxSurnameInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxSurnameInput.TabIndex = 15;
            // 
            // maskedTextBoxInputINN
            // 
            this.maskedTextBoxInputINN.Location = new System.Drawing.Point(16, 238);
            this.maskedTextBoxInputINN.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxInputINN.Mask = "000000000000";
            this.maskedTextBoxInputINN.Name = "maskedTextBoxInputINN";
            this.maskedTextBoxInputINN.Size = new System.Drawing.Size(301, 22);
            this.maskedTextBoxInputINN.TabIndex = 29;
            // 
            // labelInputINN
            // 
            this.labelInputINN.AutoSize = true;
            this.labelInputINN.Location = new System.Drawing.Point(123, 218);
            this.labelInputINN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputINN.Name = "labelInputINN";
            this.labelInputINN.Size = new System.Drawing.Size(38, 17);
            this.labelInputINN.TabIndex = 30;
            this.labelInputINN.Text = "ИНН";
            // 
            // comboBoxInputPosition
            // 
            this.comboBoxInputPosition.FormattingEnabled = true;
            this.comboBoxInputPosition.Location = new System.Drawing.Point(16, 287);
            this.comboBoxInputPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInputPosition.Name = "comboBoxInputPosition";
            this.comboBoxInputPosition.Size = new System.Drawing.Size(301, 24);
            this.comboBoxInputPosition.TabIndex = 31;
            // 
            // labelInputPosition
            // 
            this.labelInputPosition.AutoSize = true;
            this.labelInputPosition.Location = new System.Drawing.Point(123, 267);
            this.labelInputPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputPosition.Name = "labelInputPosition";
            this.labelInputPosition.Size = new System.Drawing.Size(81, 17);
            this.labelInputPosition.TabIndex = 32;
            this.labelInputPosition.Text = "Должность";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 379);
            this.Controls.Add(this.labelInputPosition);
            this.Controls.Add(this.comboBoxInputPosition);
            this.Controls.Add(this.labelInputINN);
            this.Controls.Add(this.maskedTextBoxInputINN);
            this.Controls.Add(this.maskedtextBoxInputPassID);
            this.Controls.Add(this.buttonCancelAddEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.labelInputPassID);
            this.Controls.Add(this.textBoxMiddleNameInput);
            this.Controls.Add(this.labelInputMiddlName);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxSurnameInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployee";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtextBoxInputPassID;
        private System.Windows.Forms.Button buttonCancelAddEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label labelInputPassID;
        private System.Windows.Forms.TextBox textBoxMiddleNameInput;
        private System.Windows.Forms.Label labelInputMiddlName;
        private System.Windows.Forms.TextBox textBoxNameInput;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxSurnameInput;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInputINN;
        private System.Windows.Forms.Label labelInputINN;
        private System.Windows.Forms.ComboBox comboBoxInputPosition;
        private System.Windows.Forms.Label labelInputPosition;
    }
}