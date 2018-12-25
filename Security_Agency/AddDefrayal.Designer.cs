namespace Security_Agency
{
    partial class AddDefrayal
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
            this.dateTimeInputDefrayal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxDefrayalCountInput = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddDefrayel = new System.Windows.Forms.Button();
            this.buttonCancelAddDefrayal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimeInputDefrayal
            // 
            this.dateTimeInputDefrayal.CustomFormat = "00.00.0000";
            this.dateTimeInputDefrayal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputDefrayal.Location = new System.Drawing.Point(12, 25);
            this.dateTimeInputDefrayal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputDefrayal.Name = "dateTimeInputDefrayal";
            this.dateTimeInputDefrayal.Size = new System.Drawing.Size(222, 20);
            this.dateTimeInputDefrayal.TabIndex = 26;
            this.dateTimeInputDefrayal.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Дата оплаты";
            // 
            // maskedTextBoxDefrayalCountInput
            // 
            this.maskedTextBoxDefrayalCountInput.Location = new System.Drawing.Point(12, 64);
            this.maskedTextBoxDefrayalCountInput.Mask = "00000000";
            this.maskedTextBoxDefrayalCountInput.Name = "maskedTextBoxDefrayalCountInput";
            this.maskedTextBoxDefrayalCountInput.Size = new System.Drawing.Size(222, 20);
            this.maskedTextBoxDefrayalCountInput.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Сумма оплаты";
            // 
            // buttonAddDefrayel
            // 
            this.buttonAddDefrayel.Location = new System.Drawing.Point(12, 104);
            this.buttonAddDefrayel.Name = "buttonAddDefrayel";
            this.buttonAddDefrayel.Size = new System.Drawing.Size(110, 34);
            this.buttonAddDefrayel.TabIndex = 30;
            this.buttonAddDefrayel.Text = "Добавить оплату";
            this.buttonAddDefrayel.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAddDefrayal
            // 
            this.buttonCancelAddDefrayal.Location = new System.Drawing.Point(128, 104);
            this.buttonCancelAddDefrayal.Name = "buttonCancelAddDefrayal";
            this.buttonCancelAddDefrayal.Size = new System.Drawing.Size(106, 34);
            this.buttonCancelAddDefrayal.TabIndex = 31;
            this.buttonCancelAddDefrayal.Text = "Отмена";
            this.buttonCancelAddDefrayal.UseVisualStyleBackColor = true;
            // 
            // AddDefrayal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 151);
            this.Controls.Add(this.buttonCancelAddDefrayal);
            this.Controls.Add(this.buttonAddDefrayel);
            this.Controls.Add(this.maskedTextBoxDefrayalCountInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeInputDefrayal);
            this.Name = "AddDefrayal";
            this.Text = "Добавление платежа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeInputDefrayal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDefrayalCountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddDefrayel;
        private System.Windows.Forms.Button buttonCancelAddDefrayal;
    }
}