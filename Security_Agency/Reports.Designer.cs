namespace Security_Agency
{
    partial class Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.buttonExportHTML = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.unpaidInvoicesButton = new System.Windows.Forms.Button();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonSelectCall = new System.Windows.Forms.Button();
            this.dataGridViewCalls = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 363);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonExportExcel);
            this.tabPage1.Controls.Add(this.buttonExportHTML);
            this.tabPage1.Controls.Add(this.dataGridViewInvoices);
            this.tabPage1.Controls.Add(this.unpaidInvoicesButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет по неоплатам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridViewCalls);
            this.tabPage2.Controls.Add(this.buttonSelectCall);
            this.tabPage2.Controls.Add(this.dateTimEnd);
            this.tabPage2.Controls.Add(this.dateTimeStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по вызвам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(285, 305);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(207, 27);
            this.buttonExportExcel.TabIndex = 17;
            this.buttonExportExcel.Text = "Экспорт в Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            // 
            // buttonExportHTML
            // 
            this.buttonExportHTML.Location = new System.Drawing.Point(5, 305);
            this.buttonExportHTML.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExportHTML.Name = "buttonExportHTML";
            this.buttonExportHTML.Size = new System.Drawing.Size(264, 27);
            this.buttonExportHTML.TabIndex = 16;
            this.buttonExportHTML.Text = "Экспорт в HTML";
            this.buttonExportHTML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(3, 5);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowTemplate.Height = 28;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(616, 189);
            this.dataGridViewInvoices.TabIndex = 15;
            // 
            // unpaidInvoicesButton
            // 
            this.unpaidInvoicesButton.Location = new System.Drawing.Point(5, 237);
            this.unpaidInvoicesButton.Margin = new System.Windows.Forms.Padding(2);
            this.unpaidInvoicesButton.Name = "unpaidInvoicesButton";
            this.unpaidInvoicesButton.Size = new System.Drawing.Size(264, 21);
            this.unpaidInvoicesButton.TabIndex = 14;
            this.unpaidInvoicesButton.Text = "Список неоплаченных платежей ";
            this.unpaidInvoicesButton.UseVisualStyleBackColor = true;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(6, 6);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeStart.TabIndex = 0;
            // 
            // dateTimEnd
            // 
            this.dateTimEnd.CustomFormat = "";
            this.dateTimEnd.Location = new System.Drawing.Point(228, 6);
            this.dateTimEnd.Name = "dateTimEnd";
            this.dateTimEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimEnd.TabIndex = 1;
            // 
            // buttonSelectCall
            // 
            this.buttonSelectCall.Location = new System.Drawing.Point(436, 3);
            this.buttonSelectCall.Name = "buttonSelectCall";
            this.buttonSelectCall.Size = new System.Drawing.Size(121, 23);
            this.buttonSelectCall.TabIndex = 2;
            this.buttonSelectCall.Text = "Показать вызовы";
            this.buttonSelectCall.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCalls
            // 
            this.dataGridViewCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalls.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewCalls.Name = "dataGridViewCalls";
            this.dataGridViewCalls.Size = new System.Drawing.Size(612, 299);
            this.dataGridViewCalls.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 387);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reports";
            this.Text = "Отчеты";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonExportHTML;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button unpaidInvoicesButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCalls;
        private System.Windows.Forms.Button buttonSelectCall;
        private System.Windows.Forms.DateTimePicker dateTimEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
    }
}