namespace Security_Agency
{
    partial class AddDetainedPerson
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
            this.labelInputPassID = new System.Windows.Forms.Label();
            this.textBoxMiddleNameInput = new System.Windows.Forms.TextBox();
            this.labelInputMiddlName = new System.Windows.Forms.Label();
            this.textBoxNameInput = new System.Windows.Forms.TextBox();
            this.labelNameInput = new System.Windows.Forms.Label();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxSurnameInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddDetainedPerson = new System.Windows.Forms.Button();
            this.buttonAddDetainedPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedtextBoxInputPassID
            // 
            this.maskedtextBoxInputPassID.Location = new System.Drawing.Point(16, 171);
            this.maskedtextBoxInputPassID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedtextBoxInputPassID.Mask = "0000000000";
            this.maskedtextBoxInputPassID.Name = "maskedtextBoxInputPassID";
            this.maskedtextBoxInputPassID.Size = new System.Drawing.Size(301, 22);
            this.maskedtextBoxInputPassID.TabIndex = 36;
            // 
            // labelInputPassID
            // 
            this.labelInputPassID.AutoSize = true;
            this.labelInputPassID.Location = new System.Drawing.Point(123, 151);
            this.labelInputPassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputPassID.Name = "labelInputPassID";
            this.labelInputPassID.Size = new System.Drawing.Size(117, 17);
            this.labelInputPassID.TabIndex = 35;
            this.labelInputPassID.Text = "Номер паспорта";
            // 
            // textBoxMiddleNameInput
            // 
            this.textBoxMiddleNameInput.Location = new System.Drawing.Point(16, 123);
            this.textBoxMiddleNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMiddleNameInput.Name = "textBoxMiddleNameInput";
            this.textBoxMiddleNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxMiddleNameInput.TabIndex = 34;
            // 
            // labelInputMiddlName
            // 
            this.labelInputMiddlName.AutoSize = true;
            this.labelInputMiddlName.Location = new System.Drawing.Point(123, 103);
            this.labelInputMiddlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInputMiddlName.Name = "labelInputMiddlName";
            this.labelInputMiddlName.Size = new System.Drawing.Size(71, 17);
            this.labelInputMiddlName.TabIndex = 33;
            this.labelInputMiddlName.Text = "Отчество";
            // 
            // textBoxNameInput
            // 
            this.textBoxNameInput.Location = new System.Drawing.Point(16, 75);
            this.textBoxNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNameInput.Name = "textBoxNameInput";
            this.textBoxNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxNameInput.TabIndex = 32;
            // 
            // labelNameInput
            // 
            this.labelNameInput.AutoSize = true;
            this.labelNameInput.Location = new System.Drawing.Point(123, 55);
            this.labelNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameInput.Name = "labelNameInput";
            this.labelNameInput.Size = new System.Drawing.Size(35, 17);
            this.labelNameInput.TabIndex = 31;
            this.labelNameInput.Text = "Имя";
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(123, 7);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(70, 17);
            this.labelSurnameInput.TabIndex = 30;
            this.labelSurnameInput.Text = "Фамилия";
            // 
            // textBoxSurnameInput
            // 
            this.textBoxSurnameInput.Location = new System.Drawing.Point(16, 27);
            this.textBoxSurnameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSurnameInput.Name = "textBoxSurnameInput";
            this.textBoxSurnameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxSurnameInput.TabIndex = 29;
            // 
            // buttonCancelAddDetainedPerson
            // 
            this.buttonCancelAddDetainedPerson.Location = new System.Drawing.Point(169, 203);
            this.buttonCancelAddDetainedPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddDetainedPerson.Name = "buttonCancelAddDetainedPerson";
            this.buttonCancelAddDetainedPerson.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddDetainedPerson.TabIndex = 38;
            this.buttonCancelAddDetainedPerson.Text = "Отмена";
            this.buttonCancelAddDetainedPerson.UseVisualStyleBackColor = true;
            this.buttonCancelAddDetainedPerson.Click += new System.EventHandler(this.ButtonCancelAddDetainedPerson_Click);
            // 
            // buttonAddDetainedPerson
            // 
            this.buttonAddDetainedPerson.Location = new System.Drawing.Point(5, 203);
            this.buttonAddDetainedPerson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddDetainedPerson.Name = "buttonAddDetainedPerson";
            this.buttonAddDetainedPerson.Size = new System.Drawing.Size(156, 47);
            this.buttonAddDetainedPerson.TabIndex = 37;
            this.buttonAddDetainedPerson.Text = "Добавить задержанного";
            this.buttonAddDetainedPerson.UseVisualStyleBackColor = true;
            this.buttonAddDetainedPerson.Click += new System.EventHandler(this.ButtonAddDetainedPerson_Click);
            // 
            // AddDetainedPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 271);
            this.Controls.Add(this.buttonCancelAddDetainedPerson);
            this.Controls.Add(this.buttonAddDetainedPerson);
            this.Controls.Add(this.maskedtextBoxInputPassID);
            this.Controls.Add(this.labelInputPassID);
            this.Controls.Add(this.textBoxMiddleNameInput);
            this.Controls.Add(this.labelInputMiddlName);
            this.Controls.Add(this.textBoxNameInput);
            this.Controls.Add(this.labelNameInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxSurnameInput);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddDetainedPerson";
            this.Text = "Добавление задержанного";
            this.Load += new System.EventHandler(this.AddDetainedPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtextBoxInputPassID;
        private System.Windows.Forms.Label labelInputPassID;
        private System.Windows.Forms.TextBox textBoxMiddleNameInput;
        private System.Windows.Forms.Label labelInputMiddlName;
        private System.Windows.Forms.TextBox textBoxNameInput;
        private System.Windows.Forms.Label labelNameInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxSurnameInput;
        private System.Windows.Forms.Button buttonCancelAddDetainedPerson;
        private System.Windows.Forms.Button buttonAddDetainedPerson;
    }
}