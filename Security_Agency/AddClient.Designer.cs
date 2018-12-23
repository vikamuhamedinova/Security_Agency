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
            this.textBoxInputPassID = new System.Windows.Forms.TextBox();
            this.labelInputAddress = new System.Windows.Forms.Label();
            this.textBoxInputAddress = new System.Windows.Forms.TextBox();
            this.dateTimeInputDateBirth = new System.Windows.Forms.DateTimePicker();
            this.labelInputDateBirth = new System.Windows.Forms.Label();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonCancelAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(53, 50);
            this.textBoxSurnameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxSurnameInput.TabIndex = 0;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(116, 31);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(70, 17);
            this.labelSurnameInput.TabIndex = 1;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(116, 79);
            this.labelNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(35, 17);
            this.labelNameInput.TabIndex = 2;
            this.labelNameInput.Text = "Имя";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(53, 98);
            this.textBoxNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxNameInput.TabIndex = 3;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(116, 127);
            this.labelInputMiddlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(71, 17);
            this.labelInputMiddlName.TabIndex = 4;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(53, 146);
            this.textBoxMiddleNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(296, 22);
            this.textBoxMiddleNameInput.TabIndex = 5;
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(116, 175);
            this.labelInputPassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(117, 17);
            this.labelInputPassID.TabIndex = 6;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // textBoxInputPassID
            // 
            this.textBoxInputPassID.Location = new System.Drawing.Point(53, 194);
            this.textBoxInputPassID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputPassID.Name = "textBoxInputPassID";
            this.textBoxInputPassID.Size = new System.Drawing.Size(296, 22);
            this.textBoxInputPassID.TabIndex = 7;
            this.textBoxInputPassID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInputPassID_KeyDown);
            // 
            // labelInputAddress
            // 
            this.labelInputAddress.AutoSize = true;
            this.labelInputAddress.Location = new System.Drawing.Point(116, 223);
            this.labelInputAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputAddress.Name = "labelInputAddress";
            this.labelInputAddress.Size = new System.Drawing.Size(132, 17);
            this.labelInputAddress.TabIndex = 8;
            this.labelInputAddress.Text = "Адрес проживания";
            // 
            // textBoxInputAddress
            // 
            this.textBoxInputAddress.Location = new System.Drawing.Point(53, 242);
            this.textBoxInputAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputAddress.Name = "textBoxInputAddress";
            this.textBoxInputAddress.Size = new System.Drawing.Size(296, 22);
            this.textBoxInputAddress.TabIndex = 9;
            // 
            // dateTimeInputDateBirth
            // 
            this.dateTimeInputDateBirth.Location = new System.Drawing.Point(53, 290);
            this.dateTimeInputDateBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeInputDateBirth.Name = "dateTimeInputDateBirth";
            this.dateTimeInputDateBirth.Size = new System.Drawing.Size(296, 22);
            this.dateTimeInputDateBirth.TabIndex = 10;
            // 
            // labelInputDateBirth
            // 
            this.labelInputDateBirth.AutoSize = true;
            this.labelInputDateBirth.Location = new System.Drawing.Point(116, 271);
            this.labelInputDateBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputDateBirth.Name = "labelInputDateBirth";
            this.labelInputDateBirth.Size = new System.Drawing.Size(111, 17);
            this.labelInputDateBirth.TabIndex = 11;
            this.labelInputDateBirth.Text = "Дата рождения";
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(16, 359);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(156, 47);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // buttonCancelAddClient
            // 
            this.buttonCancelAddClient.Location = new System.Drawing.Point(195, 359);
            this.buttonCancelAddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddClient.TabIndex = 13;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            this.buttonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddClient_Click);
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 425);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.labelInputDateBirth);
            this.Controls.Add(this.dateTimeInputDateBirth);
            this.Controls.Add(this.textBoxInputAddress);
            this.Controls.Add(this.labelInputAddress);
            this.Controls.Add(this.textBoxInputPassID);
            this.Controls.Add(this.labelInputPassID);
            this.Controls.Add(this.textBoxMiddleNameInput);
            this.Controls.Add(this.labelInputMiddlName);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxSurnameInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBoxInputPassID;
        private System.Windows.Forms.Label labelInputAddress;
        private System.Windows.Forms.TextBox textBoxInputAddress;
        private System.Windows.Forms.DateTimePicker dateTimeInputDateBirth;
        private System.Windows.Forms.Label labelInputDateBirth;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonCancelAddClient;
    }
}