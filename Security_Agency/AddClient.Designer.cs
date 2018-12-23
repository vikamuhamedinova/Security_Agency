namespace Security_Agency
{
    partial class AddClient
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
            this.textBoxSurnameInput = new System.Windows.Forms.TextBox();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.labelInputMiddlName = new System.Windows.Forms.Label();
            this.textBoxMiddleNameInput = new System.Windows.Forms.TextBox();
            this.labelInputPassID = new System.Windows.Forms.Label();
            this.labelInputAddress = new System.Windows.Forms.Label();
            this.textBoxInputAddress = new System.Windows.Forms.TextBox();
            this.dateTimeInputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.labelInputDateBirth = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonCancelAddClient = new System.Windows.Forms.Button();
            this.maskedtextBoxInputPassID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(40, 41);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(223, 20);
            this.textBoxSurnameInput.TabIndex = 0;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(87, 25);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(56, 13);
            this.labelSurnameInput.TabIndex = 1;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(87, 64);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(29, 13);
            this.labelNameInput.TabIndex = 2;
            this.labelNameInput.Text = "Имя";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(40, 80);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(223, 20);
            this.textBoxNameInput.TabIndex = 3;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(87, 103);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(54, 13);
            this.labelInputMiddlName.TabIndex = 4;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(40, 119);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(223, 20);
            this.textBoxMiddleNameInput.TabIndex = 5;
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(87, 142);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(91, 13);
            this.labelInputPassID.TabIndex = 6;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // labelInputAddress
            // 
            this.labelInputAddress.AutoSize = true;
            this.labelInputAddress.Location = new System.Drawing.Point(87, 181);
            this.labelInputAddress.Name = "labelInputAddress";
            this.labelInputAddress.Size = new System.Drawing.Size(103, 13);
            this.labelInputAddress.TabIndex = 8;
            this.labelInputAddress.Text = "Адрес проживания";
            // 
            // textBoxInputAddress
            // 
            this.textBoxInputAddress.Location = new System.Drawing.Point(40, 197);
            this.textBoxInputAddress.Name = "textBoxInputAddress";
            this.textBoxInputAddress.Size = new System.Drawing.Size(223, 20);
            this.textBoxInputAddress.TabIndex = 9;
            // 
            // dateTimeInputDateBirth
            // 
            this.dateTimeInputDateBirth.Location = new System.Drawing.Point(40, 236);
            this.dateTimeInputDateBirth.Name = "dateTimeInputDateBirth";
            this.dateTimeInputDateBirth.Size = new System.Drawing.Size(223, 20);
            this.dateTimeInputDateBirth.TabIndex = 10;
            // 
            // labelInputDateBirth
            // 
            this.labelInputDateBirth.AutoSize = true;
            this.labelInputDateBirth.Location = new System.Drawing.Point(87, 220);
            this.labelInputDateBirth.Name = "labelInputDateBirth";
            this.labelInputDateBirth.Size = new System.Drawing.Size(86, 13);
            this.labelInputDateBirth.TabIndex = 11;
            this.labelInputDateBirth.Text = "Дата рождения";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(12, 292);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(117, 38);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // buttonCancelAddClient
            // 
            this.buttonCancelAddClient.Location = new System.Drawing.Point(146, 292);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddClient.TabIndex = 13;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            this.buttonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddClient_Click);
            // 
            // maskedtextBoxInputPassID
            // 
            this.maskedtextBoxInputPassID.Location = new System.Drawing.Point(40, 158);
            this.maskedtextBoxInputPassID.Mask = "0000000000";
            this.maskedtextBoxInputPassID.Name = "maskedtextBoxInputPassID";
            this.maskedtextBoxInputPassID.Size = new System.Drawing.Size(223, 20);
            this.maskedtextBoxInputPassID.TabIndex = 14;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 345);
            this.Controls.Add(this.maskedtextBoxInputPassID);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.labelInputDateBirth);
            this.Controls.Add(this.dateTimeInputDateBirth);
            this.Controls.Add(this.textBoxInputAddress);
            this.Controls.Add(this.labelInputAddress);
            this.Controls.Add(this.labelInputPassID);
            this.Controls.Add(this.textBoxMiddleNameInput);
            this.Controls.Add(this.labelInputMiddlName);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxSurnameInput);
            this.Name = "AddClient";
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSurnameInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.TextBox textBoxNameInput;
        private System.Windows.Forms.Label labelInputMiddlName;
        private System.Windows.Forms.TextBox textBoxMiddleNameInput;
        private System.Windows.Forms.Label labelInputPassID;
        private System.Windows.Forms.Label labelInputAddress;
        private System.Windows.Forms.TextBox textBoxInputAddress;
        private System.Windows.Forms.DateTimePicker dateTimeInputDateBirth;
        private System.Windows.Forms.Label labelInputDateBirth;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonCancelAddClient;
        private System.Windows.Forms.MaskedTextBox maskedtextBoxInputPassID;
    }
}