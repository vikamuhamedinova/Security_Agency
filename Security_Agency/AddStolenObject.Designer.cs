namespace Security_Agency
{
    partial class AddStolenObject
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPropertyAmmountInput = new System.Windows.Forms.TextBox();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxPropertyNameInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddProperty = new System.Windows.Forms.Button();
            this.buttonAddStolenProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Количество";
            // 
            // textBoxPropertyAmmountInput
            // 
            this.textBoxPropertyAmmountInput.Location = new System.Drawing.Point(8, 64);
            this.textBoxPropertyAmmountInput.Name = "textBoxPropertyAmmountInput";
            this.textBoxPropertyAmmountInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPropertyAmmountInput.TabIndex = 46;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(36, 9);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(143, 13);
            this.labelSurnameInput.TabIndex = 45;
            this.labelSurnameInput.Text = "Наименование имущества";
            // 
            // textBoxPropertyNameInput
            // 
            this.textBoxPropertyNameInput.Location = new System.Drawing.Point(8, 25);
            this.textBoxPropertyNameInput.Name = "textBoxPropertyNameInput";
            this.textBoxPropertyNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPropertyNameInput.TabIndex = 44;
            // 
            // buttonCancelAddProperty
            // 
            this.buttonCancelAddProperty.Location = new System.Drawing.Point(131, 90);
            this.buttonCancelAddProperty.Name = "buttonCancelAddProperty";
            this.buttonCancelAddProperty.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddProperty.TabIndex = 43;
            this.buttonCancelAddProperty.Text = "Отмена";
            this.buttonCancelAddProperty.UseVisualStyleBackColor = true;
            // 
            // buttonAddStolenProperty
            // 
            this.buttonAddStolenProperty.Location = new System.Drawing.Point(8, 90);
            this.buttonAddStolenProperty.Name = "buttonAddStolenProperty";
            this.buttonAddStolenProperty.Size = new System.Drawing.Size(117, 38);
            this.buttonAddStolenProperty.TabIndex = 42;
            this.buttonAddStolenProperty.Text = "Добавить имущество";
            this.buttonAddStolenProperty.UseVisualStyleBackColor = true;
            // 
            // AddStolenObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPropertyAmmountInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPropertyNameInput);
            this.Controls.Add(this.buttonCancelAddProperty);
            this.Controls.Add(this.buttonAddStolenProperty);
            this.Name = "AddStolenObject";
            this.Text = "Добавление украденного имущества";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPropertyAmmountInput;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxPropertyNameInput;
        private System.Windows.Forms.Button buttonCancelAddProperty;
        private System.Windows.Forms.Button buttonAddStolenProperty;
    }
}