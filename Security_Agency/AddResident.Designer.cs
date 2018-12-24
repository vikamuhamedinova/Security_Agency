namespace Security_Agency
{
    partial class AddResident
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
            this.buttonCancelAddResident = new System.Windows.Forms.Button();
            this.buttonAddResident = new System.Windows.Forms.Button();
            this.labelInputDateBirth = new System.Windows.Forms.Label();
            this.dateTimeInputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.labelInputPassID = new System.Windows.Forms.Label();
            this.textBoxMiddleNameInput = new System.Windows.Forms.TextBox();
            this.labelInputMiddlName = new System.Windows.Forms.Label();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxSurnameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedtextBoxInputPassID
            // 
            this.maskedtextBoxInputPassID.Location = new System.Drawing.Point(16, 171);
            this.maskedtextBoxInputPassID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtextBoxInputPassID.Mask = "0000000000";
            this.maskedtextBoxInputPassID.Name = "maskedtextBoxInputPassID";
            this.maskedtextBoxInputPassID.Size = new System.Drawing.Size(296, 22);
            this.maskedtextBoxInputPassID.TabIndex = 28;
            // 
            // buttonCancelAddResident
            // 
            this.buttonCancelAddResident.Location = new System.Drawing.Point(184, 265);
            this.buttonCancelAddResident.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddResident.Name = "buttonCancelAddResident";
            this.buttonCancelAddResident.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddResident.TabIndex = 27;
            this.buttonCancelAddResident.Text = "Отмена";
            this.buttonCancelAddResident.UseVisualStyleBackColor = true;
            this.buttonCancelAddResident.Click += new System.EventHandler(this.ButtonCancelAddResident_Click);
            // 
            // buttonAddResident
            // 
            this.buttonAddResident.Location = new System.Drawing.Point(16, 265);
            this.buttonAddResident.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddResident.Name = "buttonAddResident";
            this.buttonAddResident.Size = new System.Drawing.Size(156, 47);
            this.buttonAddResident.TabIndex = 26;
            this.buttonAddResident.Text = "Добавить жителя";
            this.buttonAddResident.UseVisualStyleBackColor = true;
            this.buttonAddResident.Click += new System.EventHandler(this.ButtonAddResident_Click);
            // 
            // labelInputDateBirth
            // 
            this.labelInputDateBirth.AutoSize = true;
            this.labelInputDateBirth.Location = new System.Drawing.Point(79, 199);
            this.labelInputDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputDateBirth.Name = "labelInputDateBirth";
            this.labelInputDateBirth.Size = new System.Drawing.Size(111, 17);
            this.labelInputDateBirth.TabIndex = 25;
            this.labelInputDateBirth.Text = "Дата рождения";
            // 
            // dateTimeInputDateBirth
            // 
            this.dateTimeInputDateBirth.CustomFormat = "00.00.0000";
            this.dateTimeInputDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputDateBirth.Location = new System.Drawing.Point(16, 219);
            this.dateTimeInputDateBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputDateBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputDateBirth.Name = "dateTimeInputDateBirth";
            this.dateTimeInputDateBirth.Size = new System.Drawing.Size(296, 22);
            this.dateTimeInputDateBirth.TabIndex = 24;
            this.dateTimeInputDateBirth.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(79, 151);
            this.labelInputPassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(117, 17);
            this.labelInputPassID.TabIndex = 21;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(16, 123);
            this.textBoxMiddleNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxMiddleNameInput.TabIndex = 20;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(79, 103);
            this.labelInputMiddlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(71, 17);
            this.labelInputMiddlName.TabIndex = 19;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(16, 75);
            this.textBoxNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxNameInput.TabIndex = 18;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(79, 55);
            this.labelNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(35, 17);
            this.labelNameInput.TabIndex = 17;
            this.labelNameInput.Text = "Имя";
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(79, 7);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(70, 17);
            this.labelSurnameInput.TabIndex = 16;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(16, 27);
            this.textBoxSurnameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxSurnameInput.TabIndex = 15;
            // 
            // AddResident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 325);
            this.Controls.Add(this.maskedtextBoxInputPassID);
            this.Controls.Add(this.buttonCancelAddResident);
            this.Controls.Add(this.buttonAddResident);
            this.Controls.Add(this.labelInputDateBirth);
            this.Controls.Add(this.dateTimeInputDateBirth);
            this.Controls.Add(this.labelInputPassID);
            this.Controls.Add(this.textBoxMiddleNameInput);
            this.Controls.Add(this.labelInputMiddlName);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxSurnameInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddResident";
            this.Text = "Добавление жителя";
            this.Load += new System.EventHandler(this.AddResident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtextBoxInputPassID;
        private System.Windows.Forms.Button buttonCancelAddResident;
        private System.Windows.Forms.Button buttonAddResident;
        private System.Windows.Forms.Label labelInputDateBirth;
        private System.Windows.Forms.DateTimePicker dateTimeInputDateBirth;
        private System.Windows.Forms.Label labelInputPassID;
        private System.Windows.Forms.TextBox textBoxMiddleNameInput;
        private System.Windows.Forms.Label labelInputMiddlName;
        private System.Windows.Forms.TextBox textBoxNameInput;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxSurnameInput;
    }
}