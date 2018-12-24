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
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedtextBoxInputPassID
            // 
            this.maskedtextBoxInputPassID.Location = new System.Drawing.Point(12, 152);
            this.maskedtextBoxInputPassID.Mask = "0000000000";
            this.maskedtextBoxInputPassID.Name = "maskedtextBoxInputPassID";
            this.maskedtextBoxInputPassID.Size = new System.Drawing.Size(227, 20);
            this.maskedtextBoxInputPassID.TabIndex = 28;
            // 
            // buttonCancelAddEmployee
            // 
            this.buttonCancelAddEmployee.Location = new System.Drawing.Point(135, 260);
            this.buttonCancelAddEmployee.Name = "buttonCancelAddEmployee";
            this.buttonCancelAddEmployee.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddEmployee.TabIndex = 27;
            this.buttonCancelAddEmployee.Text = "Отмена";
            this.buttonCancelAddEmployee.UseVisualStyleBackColor = true;
            this.buttonCancelAddEmployee.Click += new System.EventHandler(this.ButtonCancelAddEmployee_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(12, 260);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(117, 38);
            this.buttonAddEmployee.TabIndex = 26;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.ButtonAddEmployee_Click);
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(92, 136);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(91, 13);
            this.labelInputPassID.TabIndex = 21;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(12, 113);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxMiddleNameInput.TabIndex = 20;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(92, 97);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(54, 13);
            this.labelInputMiddlName.TabIndex = 19;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(12, 74);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxNameInput.TabIndex = 18;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(92, 58);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(29, 13);
            this.labelNameInput.TabIndex = 17;
            this.labelNameInput.Text = "Имя";
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(92, 19);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(56, 13);
            this.labelSurnameInput.TabIndex = 16;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(12, 35);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxSurnameInput.TabIndex = 15;
            // 
            // maskedTextBoxInputINN
            // 
            this.maskedTextBoxInputINN.Location = new System.Drawing.Point(12, 193);
            this.maskedTextBoxInputINN.Mask = "000000000000";
            this.maskedTextBoxInputINN.Name = "maskedTextBoxInputINN";
            this.maskedTextBoxInputINN.Size = new System.Drawing.Size(227, 20);
            this.maskedTextBoxInputINN.TabIndex = 29;
            // 
            // labelInputINN
            // 
            this.labelInputINN.AutoSize = true;
            this.labelInputINN.Location = new System.Drawing.Point(92, 177);
            this.labelInputINN.Name = "labelInputINN";
            this.labelInputINN.Size = new System.Drawing.Size(31, 13);
            this.labelInputINN.TabIndex = 30;
            this.labelInputINN.Text = "ИНН";
            // 
            // comboBoxInputPosition
            // 
            this.comboBoxInputPosition.FormattingEnabled = true;
            this.comboBoxInputPosition.Location = new System.Drawing.Point(12, 233);
            this.comboBoxInputPosition.Name = "comboBoxInputPosition";
            this.comboBoxInputPosition.Size = new System.Drawing.Size(227, 21);
            this.comboBoxInputPosition.TabIndex = 31;
            // 
            // labelInputPosition
            // 
            this.labelInputPosition.AutoSize = true;
            this.labelInputPosition.Location = new System.Drawing.Point(92, 217);
            this.labelInputPosition.Name = "labelInputPosition";
            this.labelInputPosition.Size = new System.Drawing.Size(65, 13);
            this.labelInputPosition.TabIndex = 32;
            this.labelInputPosition.Text = "Должность";
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(245, 233);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(137, 21);
            this.buttonAddPosition.TabIndex = 33;
            this.buttonAddPosition.Text = "Добавить должность";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 308);
            this.Controls.Add(this.buttonAddPosition);
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
            this.Name = "AddEmployee";
            this.Text = "Добавление сотрудника";
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
        private System.Windows.Forms.Button buttonAddPosition;
    }
}