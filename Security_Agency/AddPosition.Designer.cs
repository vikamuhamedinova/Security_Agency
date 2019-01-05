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
            this.buttonCancelAddClient.Location = new System.Drawing.Point(180, 111);
            this.buttonCancelAddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelAddClient.Name = "buttonCancelAddClient";
            this.buttonCancelAddClient.Size = new System.Drawing.Size(156, 47);
            this.buttonCancelAddClient.TabIndex = 29;
            this.buttonCancelAddClient.Text = "Отмена";
            this.buttonCancelAddClient.UseVisualStyleBackColor = true;
            this.buttonCancelAddClient.Click += new System.EventHandler(this.ButtonCancelAddPosition_Click);
            // 
            // buttonAddPosition
            // 
            this.buttonAddPosition.Location = new System.Drawing.Point(16, 111);
            this.buttonAddPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddPosition.Name = "buttonAddPosition";
            this.buttonAddPosition.Size = new System.Drawing.Size(156, 47);
            this.buttonAddPosition.TabIndex = 28;
            this.buttonAddPosition.Text = "Добавить должность";
            this.buttonAddPosition.UseVisualStyleBackColor = true;
            this.buttonAddPosition.Click += new System.EventHandler(this.ButtonAddPosition_Click);
            // 
            // labelSurnameInput
            // 
            this.labelSurnameInput.AutoSize = true;
            this.labelSurnameInput.Location = new System.Drawing.Point(67, 38);
            this.labelSurnameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurnameInput.Name = "labelSurnameInput";
            this.labelSurnameInput.Size = new System.Drawing.Size(181, 17);
            this.labelSurnameInput.TabIndex = 31;
            this.labelSurnameInput.Text = "Наименование должности";
            // 
            // textBoxPositionTitleInput
            // 
            this.textBoxPositionTitleInput.Location = new System.Drawing.Point(16, 58);
            this.textBoxPositionTitleInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPositionTitleInput.Name = "textBoxPositionTitleInput";
            this.textBoxPositionTitleInput.Size = new System.Drawing.Size(301, 22);
            this.textBoxPositionTitleInput.TabIndex = 30;
            // 
            // AddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 172);
            this.Controls.Add(this.labelSurnameInput);
            this.Controls.Add(this.textBoxPositionTitleInput);
            this.Controls.Add(this.buttonCancelAddClient);
            this.Controls.Add(this.buttonAddPosition);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPosition";
            this.Text = "AddPosition";
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