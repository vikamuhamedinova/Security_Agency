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
            this.labelSurnameInput.Location = new System.Drawing.Point(103, 11);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(122, 17);
            this.labelSurnameInput.TabIndex = 35;
            this.labelSurnameInput.Text = "Адресс квартиры";
            // 
            // textBoxApartmentAdressInput
            // 
            this.textBoxApartmentAdressInput.Location = new System.Drawing.Point(17, 31);
            this.textBoxApartmentAdressInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApartmentAdressInput.Name = "textBoxApartmentAdressInput";
            this.textBoxApartmentAdressInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxApartmentAdressInput.TabIndex = 34;
            // 
            // buttonCancelAddClient
            // 
            this.buttonCancelAddClient.Location = new System.Drawing.Point(181, 90);
            this.buttonCancelAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddClient.TabIndex = 33;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            this.buttonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddApartmentClick);
            // 
            // buttonAddApartment
            // 
            this.buttonAddApartment.Location = new System.Drawing.Point(17, 90);
            this.buttonAddApartment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddApartment.Name = "buttonAddApartment";
            this.buttonAddApartment.Size = new System.Drawing.Size(156, 47);
            this.buttonAddApartment.TabIndex = 32;
            this.buttonAddApartment.Text = "Добавить квартиру";
            this.buttonAddApartment.UseVisualStyleBackColor = true;
            this.buttonAddApartment.Click += new System.EventHandler(this.ButtonAddApartment_Click);
            // 
            // AddApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 175);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxApartmentAdressInput);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddApartment);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddApartment";
            this.Text = "Добавление квартиры";
            this.Load += new System.EventHandler(this.AddApartment_Load);
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