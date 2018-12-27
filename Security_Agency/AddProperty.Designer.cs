namespace Security_Agency
{
    partial class AddProperty
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
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxPropertyNameInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddProperty = new System.Windows.Forms.Button();
            this.buttonAddProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPropertyCostInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(53, 34);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(182, 17);
            this.labelSurnameInput.TabIndex = 39;
            this.labelSurnameInput.Text = "Наименование имущества";
            // 
            // textBoxPropertyNameInput
            // 
            this.textBoxPropertyNameInput.Location = new System.Drawing.Point(16, 54);
            this.textBoxPropertyNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPropertyNameInput.Name = "textBoxPropertyNameInput";
            this.textBoxPropertyNameInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPropertyNameInput.TabIndex = 38;
            // 
            // buttonCancelAddProperty
            // 
            this.buttonCancelAddProperty.Location = new System.Drawing.Point(180, 134);
            this.buttonCancelAddProperty.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddProperty.Name = "buttonCancelAddProperty";
            this.buttonCancelAddProperty.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddProperty.TabIndex = 37;
            this.buttonCancelAddProperty.Text = "Отмена";
            this.buttonCancelAddProperty.UseVisualStyleBackColor = true;
            this.buttonCancelAddProperty.Click += new System.EventHandler(this.ButtonCancelAddPropertyClick);
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(16, 134);
            this.buttonAddProperty.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(156, 47);
            this.buttonAddProperty.TabIndex = 36;
            this.buttonAddProperty.Text = "Добавить имущество";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.ButtonAddProperty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Стоимость имущества";
            // 
            // textBoxPropertyCostInput
            // 
            this.textBoxPropertyCostInput.Location = new System.Drawing.Point(16, 105);
            this.textBoxPropertyCostInput.Name = "textBoxPropertyCostInput";
            this.textBoxPropertyCostInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPropertyCostInput.TabIndex = 42;
            // 
            // AddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 193);
            this.Controls.Add(this.textBoxPropertyCostInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPropertyNameInput);
            this.Controls.Add(this.buttonCancelAddProperty);
            this.Controls.Add(this.buttonAddProperty);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProperty";
            this.Text = "AddProperty";
            this.Load += new System.EventHandler(this.AddProperty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxPropertyNameInput;
        private System.Windows.Forms.Button buttonCancelAddProperty;
        private System.Windows.Forms.Button buttonAddProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPropertyCostInput;
    }
}