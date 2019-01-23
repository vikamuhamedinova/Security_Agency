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
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.buttonExportHTML = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCalls = new System.Windows.Forms.DataGridView();
            this.buttonSelectCall = new System.Windows.Forms.Button();
            this.dateTimEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.unpaidFinesButton = new System.Windows.Forms.Button();
            this.commonInfoButton = new System.Windows.Forms.Button();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.unpaidInvoicesButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 566);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unpaidInvoicesButton);
            this.tabPage1.Controls.Add(this.contractComboBox);
            this.tabPage1.Controls.Add(this.commonInfoButton);
            this.tabPage1.Controls.Add(this.unpaidFinesButton);
            this.tabPage1.Controls.Add(this.buttonExportExcel);
            this.tabPage1.Controls.Add(this.buttonExportHTML);
            this.tabPage1.Controls.Add(this.dataGridViewInvoices);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(844, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет по неоплатам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(398, 467);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(276, 54);
            this.buttonExportExcel.TabIndex = 17;
            this.buttonExportExcel.Text = "Экспорт в Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // buttonExportHTML
            // 
            this.buttonExportHTML.Location = new System.Drawing.Point(7, 467);
            this.buttonExportHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportHTML.Name = "buttonExportHTML";
            this.buttonExportHTML.Size = new System.Drawing.Size(352, 54);
            this.buttonExportHTML.TabIndex = 16;
            this.buttonExportHTML.Text = "Экспорт в HTML";
            this.buttonExportHTML.UseVisualStyleBackColor = true;
            this.buttonExportHTML.Click += new System.EventHandler(this.buttonExportHTML_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(4, 6);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowTemplate.Height = 28;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(835, 270);
            this.dataGridViewInvoices.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridViewCalls);
            this.tabPage2.Controls.Add(this.buttonSelectCall);
            this.tabPage2.Controls.Add(this.dateTimEnd);
            this.tabPage2.Controls.Add(this.dateTimeStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(835, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет по вызвам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // dataGridViewCalls
            // 
            this.dataGridViewCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalls.Location = new System.Drawing.Point(8, 39);
            this.dataGridViewCalls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCalls.Name = "dataGridViewCalls";
            this.dataGridViewCalls.Size = new System.Drawing.Size(816, 368);
            this.dataGridViewCalls.TabIndex = 3;
            // 
            // buttonSelectCall
            // 
            this.buttonSelectCall.Location = new System.Drawing.Point(581, 4);
            this.buttonSelectCall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSelectCall.Name = "buttonSelectCall";
            this.buttonSelectCall.Size = new System.Drawing.Size(161, 28);
            this.buttonSelectCall.TabIndex = 2;
            this.buttonSelectCall.Text = "Показать вызовы";
            this.buttonSelectCall.UseVisualStyleBackColor = true;
            // 
            // dateTimEnd
            // 
            this.dateTimEnd.CustomFormat = "";
            this.dateTimEnd.Location = new System.Drawing.Point(304, 7);
            this.dateTimEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimEnd.Name = "dateTimEnd";
            this.dateTimEnd.Size = new System.Drawing.Size(265, 22);
            this.dateTimEnd.TabIndex = 1;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Location = new System.Drawing.Point(8, 7);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(265, 22);
            this.dateTimeStart.TabIndex = 0;
            // 
            // unpaidFinesButton
            // 
            this.unpaidFinesButton.BackColor = System.Drawing.Color.Transparent;
            this.unpaidFinesButton.Location = new System.Drawing.Point(7, 296);
            this.unpaidFinesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unpaidFinesButton.Name = "unpaidFinesButton";
            this.unpaidFinesButton.Size = new System.Drawing.Size(352, 45);
            this.unpaidFinesButton.TabIndex = 18;
            this.unpaidFinesButton.Text = "Список неоплаченных штрафов по договору";
            this.unpaidFinesButton.UseVisualStyleBackColor = true;
            this.unpaidFinesButton.Click += new System.EventHandler(this.unpaidFinesButton_Click);
            // 
            // commonInfoButton
            // 
            this.commonInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.commonInfoButton.Location = new System.Drawing.Point(7, 394);
            this.commonInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commonInfoButton.Name = "commonInfoButton";
            this.commonInfoButton.Size = new System.Drawing.Size(352, 45);
            this.commonInfoButton.TabIndex = 19;
            this.commonInfoButton.Text = "Общая денежная информация по договору";
            this.commonInfoButton.UseVisualStyleBackColor = true;
            this.commonInfoButton.Click += new System.EventHandler(this.commonInfoButton_Click);
            // 
            // contractComboBox
            // 
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Location = new System.Drawing.Point(398, 356);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(276, 24);
            this.contractComboBox.TabIndex = 20;
            // 
            // unpaidInvoicesButton
            // 
            this.unpaidInvoicesButton.BackColor = System.Drawing.Color.Transparent;
            this.unpaidInvoicesButton.Location = new System.Drawing.Point(7, 345);
            this.unpaidInvoicesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unpaidInvoicesButton.Name = "unpaidInvoicesButton";
            this.unpaidInvoicesButton.Size = new System.Drawing.Size(352, 45);
            this.unpaidInvoicesButton.TabIndex = 21;
            this.unpaidInvoicesButton.Text = "Список неоплаченных платежей по договору";
            this.unpaidInvoicesButton.UseVisualStyleBackColor = true;
            this.unpaidInvoicesButton.Click += new System.EventHandler(this.unpaidInvoicesButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 616);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reports";
            this.Text = "Отчеты";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Button buttonExportHTML;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCalls;
        private System.Windows.Forms.Button buttonSelectCall;
        private System.Windows.Forms.DateTimePicker dateTimEnd;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.ComboBox contractComboBox;
        private System.Windows.Forms.Button commonInfoButton;
        private System.Windows.Forms.Button unpaidFinesButton;
        private System.Windows.Forms.Button unpaidInvoicesButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}