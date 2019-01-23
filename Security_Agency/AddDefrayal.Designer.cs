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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddDefrayel = new System.Windows.Forms.Button();
            this.buttonCancelAddDefrayal = new System.Windows.Forms.Button();
            this.textBoxDefrayalCountInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeInputDefrayal
            // 
            this.dateTimeInputDefrayal.CustomFormat = "00.00.0000";
            this.dateTimeInputDefrayal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInputDefrayal.Location = new System.Drawing.Point(16, 31);
            this.dateTimeInputDefrayal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInputDefrayal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimeInputDefrayal.Name = "dateTimeInputDefrayal";
            this.dateTimeInputDefrayal.Size = new System.Drawing.Size(295, 22);
            this.dateTimeInputDefrayal.TabIndex = 26;
            this.dateTimeInputDefrayal.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Дата оплаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Сумма оплаты";
            // 
            // buttonAddDefrayel
            // 
            this.buttonAddDefrayel.Location = new System.Drawing.Point(16, 128);
            this.buttonAddDefrayel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDefrayel.Name = "buttonAddDefrayel";
            this.buttonAddDefrayel.Size = new System.Drawing.Size(147, 42);
            this.buttonAddDefrayel.TabIndex = 30;
            this.buttonAddDefrayel.Text = "Добавить оплату";
            this.buttonAddDefrayel.UseVisualStyleBackColor = true;
            this.buttonAddDefrayel.Click += new System.EventHandler(this.ButtonAddDefrayal_Click);
            // 
            // buttonCancelAddDefrayal
            // 
            this.buttonCancelAddDefrayal.Location = new System.Drawing.Point(171, 128);
            this.buttonCancelAddDefrayal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddDefrayal.Name = "buttonCancelAddDefrayal";
            this.buttonCancelAddDefrayal.Size = new System.Drawing.Size(141, 42);
            this.buttonCancelAddDefrayal.TabIndex = 31;
            this.buttonCancelAddDefrayal.Text = "Отмена";
            this.buttonCancelAddDefrayal.UseVisualStyleBackColor = true;
            this.buttonCancelAddDefrayal.Click += new System.EventHandler(this.ButtonCancelAddDefrayal_Click);
            // 
            // textBoxDefrayalCountInput
            // 
            this.textBoxDefrayalCountInput.Location = new System.Drawing.Point(16, 79);
            this.textBoxDefrayalCountInput.Name = "textBoxDefrayalCountInput";
            this.textBoxDefrayalCountInput.Size = new System.Drawing.Size(300, 22);
            this.textBoxDefrayalCountInput.TabIndex = 32;
            // 
            // AddDefrayal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 186);
            this.Controls.Add(this.textBoxDefrayalCountInput);
            this.Controls.Add(this.buttonCancelAddDefrayal);
            this.Controls.Add(this.buttonAddDefrayel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeInputDefrayal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDefrayal";
            this.Text = "Добавление платежа";
            this.Load += new System.EventHandler(this.AddDefrayal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeInputDefrayal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddDefrayel;
        private System.Windows.Forms.Button buttonCancelAddDefrayal;
        private System.Windows.Forms.TextBox textBoxDefrayalCountInput;
    }
}