namespace Security_Agency
{
    partial class AddApartment
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
            this.textBoxApartmentAdressInput = new System.Windows.Forms.TextBox();
            this.buttonCancelAddClient = new System.Windows.Forms.Button();
            this.buttonAddApartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(77, 9);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(96, 13);
            this.labelSurnameInput.TabIndex = 35;
            this.labelSurnameInput.Text = "Адресс квартиры";
            // 
            // textBoxApartmentAdressInput
            // 
            this.textBoxApartmentAdressInput.Location = new System.Drawing.Point(13, 25);
            this.textBoxApartmentAdressInput.Name = "textBoxApartmentAdressInput";
            this.textBoxApartmentAdressInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxApartmentAdressInput.TabIndex = 34;
            // 
            // buttonCancelAddClient
            // 
            this.buttonCancelAddClient.Location = new System.Drawing.Point(136, 68);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddClient.TabIndex = 33;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.Location = new System.Drawing.Point(13, 68);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(117, 38);
            this.buttonAddApartment.TabIndex = 32;
            this.buttonAddApartment.Text = "Добавить квартиру";
            this.buttonAddApartment.UseVisualStyleBackColor = true;
            // 
            // AddApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 121);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxApartmentAdressInput);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddApartment);
            this.Name = "AddApartment";
            this.Text = "Добавление квартиры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxApartmentAdressInput;
        private System.Windows.Forms.Button buttonCancelAddClient;
        private System.Windows.Forms.Button buttonAddApartment;
    }
}