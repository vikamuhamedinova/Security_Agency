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
            this.label1.Location = new System.Drawing.Point(48, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Количество";
            // 
            // textBoxPropertyAmmountInput
            // 
            this.textBoxPropertyAmmountInput.Location = new System.Drawing.Point(11, 79);
            this.textBoxPropertyAmmountInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPropertyAmmountInput.Name = "textBoxPropertyAmmountInput";
            this.textBoxPropertyAmmountInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPropertyAmmountInput.TabIndex = 46;
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(48, 11);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(182, 17);
            this.labelSurnameInput.TabIndex = 45;
            this.labelSurnameInput.Text = "Наименование имущества";
            // 
            // textBoxPropertyNameInput
            // 
            this.textBoxPropertyNameInput.Location = new System.Drawing.Point(11, 31);
            this.textBoxPropertyNameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPropertyNameInput.Name = "textBoxPropertyNameInput";
            this.textBoxPropertyNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPropertyNameInput.TabIndex = 44;
            // 
            // buttonCancelAddProperty
            // 
            this.buttonCancelAddProperty.Location = new System.Drawing.Point(175, 111);
            this.buttonCancelAddProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddProperty.Name = "buttonCancelAddProperty";
            this.buttonCancelAddProperty.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddProperty.TabIndex = 43;
            this.buttonCancelAddProperty.Text = "Отмена";
            this.buttonCancelAddProperty.UseVisualStyleBackColor = true;
            this.buttonCancelAddProperty.Click += new System.EventHandler(this.ButtonCancelAddStolenObject_Click);
            // 
            // buttonAddStolenProperty
            // 
            this.buttonAddStolenProperty.Location = new System.Drawing.Point(11, 111);
            this.buttonAddStolenProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddStolenProperty.Name = "buttonAddStolenProperty";
            this.buttonAddStolenProperty.Size = new System.Drawing.Size(156, 47);
            this.buttonAddStolenProperty.TabIndex = 42;
            this.buttonAddStolenProperty.Text = "Добавить имущество";
            this.buttonAddStolenProperty.UseVisualStyleBackColor = true;
            this.buttonAddStolenProperty.Click += new System.EventHandler(this.ButtonAddStolenObject_Click);
            // 
            // AddStolenObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPropertyAmmountInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPropertyNameInput);
            this.Controls.Add(this.buttonCancelAddProperty);
            this.Controls.Add(this.buttonAddStolenProperty);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStolenObject";
            this.Text = "Добавление украденного имущества";
            this.Load += new System.EventHandler(this.AddStolenObject_Load);
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