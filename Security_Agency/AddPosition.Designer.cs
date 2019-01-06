namespace Security_Agency
{
    partial class AddPosition
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
            this.buttonCancelAddClient = new System.Windows.Forms.Button();
            this.buttonAddPosition = new System.Windows.Forms.Button();
            this.labelSurnameInput = new System.Windows.Forms.Label();
            this.textBoxPositionTitleInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancelAddClient
            // 
            this.buttonCancelAddClient.Location = new System.Drawing.Point(135, 90);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(117, 38);
            this.buttonCancelAddClient.TabIndex = 29;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            this.buttonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddPosition_Click);
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(12, 90);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(117, 38);
            this.buttonAddPosition.TabIndex = 28;
            this.buttonAddPosition.Text = "Добавить должность";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(50, 31);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(141, 13);
            this.labelSurnameInput.TabIndex = 31;
            this.labelSurnameInput.Text = "Наименование должности";
            // 
            // textBoxPositionTitleInput
            // 
            this.textBoxPositionTitleInput.Location = new System.Drawing.Point(12, 47);
            this.textBoxPositionTitleInput.Name = "textBoxPositionTitleInput";
            this.textBoxPositionTitleInput.Size = new System.Drawing.Size(227, 20);
            this.textBoxPositionTitleInput.TabIndex = 30;
            // 
            // AddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPositionTitleInput);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddPosition);
            this.Name = "AddPosition";
            this.Text = "Добавление должности";
            this.Load += new System.EventHandler(this.AddPosition_Load);
            this.Click += new System.EventHandler(this.AddPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAddClient;
        private System.Windows.Forms.Button buttonAddPosition;
        private System.Windows.Forms.Label labelSurnameInput;
        private System.Windows.Forms.TextBox textBoxPositionTitleInput;
    }
}