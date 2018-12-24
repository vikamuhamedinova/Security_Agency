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
            this.labelSurnameInput.Location = new System.Drawing.Point(40, 28);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(143, 13);
            this.labelSurnameInput.TabIndex = 39;
            this.labelSurnameInput.Text = "Наименование имущества";
            // 
            // textBoxPropertyNameInput
            // 
            this.textBoxPropertyNameInput.Location = new System.Drawing.Point(12, 44);
            this.textBoxPropertyNameInput.Name = "textBoxPropertyNameInput";
            this.textBoxPropertyNameInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPropertyNameInput.TabIndex = 38;
            // 
            // buttonCancelAddProperty
            // 
            this.buttonCancelAddProperty.Location = new System.Drawing.Point(135, 109);
            this.buttonCancelAddProperty.Name = "buttonCancelAddProperty";
            this.buttonCancelAddProperty.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddProperty.TabIndex = 37;
            this.buttonCancelAddProperty.Text = "Отмена";
            this.buttonCancelAddProperty.UseVisualStyleBackColor = true;
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(12, 109);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(117, 38);
            this.buttonAddProperty.TabIndex = 36;
            this.buttonAddProperty.Text = "Добавить имущество";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Стоимость имущества";
            // 
            // textBoxPropertyCostInput
            // 
            this.textBoxPropertyCostInput.Location = new System.Drawing.Point(12, 83);
            this.textBoxPropertyCostInput.Name = "textBoxPropertyCostInput";
            this.textBoxPropertyCostInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPropertyCostInput.TabIndex = 40;
            // 
            // AddProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPropertyCostInput);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPropertyNameInput);
            this.Controls.Add(this.buttonCancelAddProperty);
            this.Controls.Add(this.buttonAddProperty);
            this.Name = "AddProperty";
            this.Text = "AddProperty";
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