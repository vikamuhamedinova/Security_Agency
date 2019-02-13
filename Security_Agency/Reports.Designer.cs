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
            this.label2 = new System.Windows.Forms.Label();
            this.labelContract = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.unpaidInvoicesButton = new System.Windows.Forms.Button();
            this.contractComboBox = new System.Windows.Forms.ComboBox();
            this.commonInfoButton = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.buttonExportHTML = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCalls = new System.Windows.Forms.DataGridView();
            this.buttonSelectCall = new System.Windows.Forms.Button();
            this.dateTimEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonExportHTML1 = new System.Windows.Forms.Button();
            this.buttonExportExcel1 = new System.Windows.Forms.Button();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 609);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelContract);
            this.tabPage1.Controls.Add(this.labelClient);
            this.tabPage1.Controls.Add(this.unpaidInvoicesButton);
            this.tabPage1.Controls.Add(this.contractComboBox);
            this.tabPage1.Controls.Add(this.commonInfoButton);
            this.tabPage1.Controls.Add(this.buttonExportExcel);
            this.tabPage1.Controls.Add(this.buttonExportHTML);
            this.tabPage1.Controls.Add(this.dataGridViewInvoices);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(844, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчет по счетам";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Выберите договор";
            // 
            // labelContract
            // 
            this.labelContract.AutoSize = true;
            this.labelContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelContract.Location = new System.Drawing.Point(440, 19);
            this.labelContract.Name = "labelContract";
            this.labelContract.Size = new System.Drawing.Size(154, 20);
            this.labelContract.TabIndex = 23;
            this.labelContract.Text = "Номер договора:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelClient.Location = new System.Drawing.Point(8, 19);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(75, 20);
            this.labelClient.TabIndex = 22;
            this.labelClient.Text = "Клиент:";
            // 
            // unpaidInvoicesButton
            // 
            this.unpaidInvoicesButton.BackColor = System.Drawing.Color.Transparent;
            this.unpaidInvoicesButton.Location = new System.Drawing.Point(7, 413);
            this.unpaidInvoicesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unpaidInvoicesButton.Name = "unpaidInvoicesButton";
            this.unpaidInvoicesButton.Size = new System.Drawing.Size(352, 45);
            this.unpaidInvoicesButton.TabIndex = 21;
            this.unpaidInvoicesButton.Text = "Список неоплаченных счетов по договору";
            this.unpaidInvoicesButton.UseVisualStyleBackColor = true;
            this.unpaidInvoicesButton.Click += new System.EventHandler(this.UnpaidInvoicesButton_Click);
            // 
            // contractComboBox
            // 
            this.contractComboBox.FormattingEnabled = true;
            this.contractComboBox.Location = new System.Drawing.Point(398, 413);
            this.contractComboBox.Name = "contractComboBox";
            this.contractComboBox.Size = new System.Drawing.Size(276, 24);
            this.contractComboBox.TabIndex = 20;
            // 
            // commonInfoButton
            // 
            this.commonInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.commonInfoButton.Location = new System.Drawing.Point(7, 364);
            this.commonInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commonInfoButton.Name = "commonInfoButton";
            this.commonInfoButton.Size = new System.Drawing.Size(352, 45);
            this.commonInfoButton.TabIndex = 19;
            this.commonInfoButton.Text = "Общая денежная информация по договору";
            this.commonInfoButton.UseVisualStyleBackColor = true;
            this.commonInfoButton.Click += new System.EventHandler(this.CommonInfoButton_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(398, 501);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(276, 54);
            this.buttonExportExcel.TabIndex = 17;
            this.buttonExportExcel.Text = "Экспорт в Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.ButtonExportExcel_Click);
            // 
            // buttonExportHTML
            // 
            this.buttonExportHTML.Location = new System.Drawing.Point(7, 501);
            this.buttonExportHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportHTML.Name = "buttonExportHTML";
            this.buttonExportHTML.Size = new System.Drawing.Size(352, 54);
            this.buttonExportHTML.TabIndex = 16;
            this.buttonExportHTML.Text = "Экспорт в HTML";
            this.buttonExportHTML.UseVisualStyleBackColor = true;
            this.buttonExportHTML.Click += new System.EventHandler(this.ButtonExportHTML_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(6, 54);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowTemplate.Height = 28;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(835, 270);
            this.dataGridViewInvoices.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExportExcel1);
            this.tabPage2.Controls.Add(this.buttonExportHTML1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridViewCalls);
            this.tabPage2.Controls.Add(this.buttonSelectCall);
            this.tabPage2.Controls.Add(this.dateTimEnd);
            this.tabPage2.Controls.Add(this.dateTimeStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(844, 580);
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
            this.dataGridViewCalls.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCalls.Name = "dataGridViewCalls";
            this.dataGridViewCalls.Size = new System.Drawing.Size(816, 368);
            this.dataGridViewCalls.TabIndex = 3;
            // 
            // buttonSelectCall
            // 
            this.buttonSelectCall.Location = new System.Drawing.Point(581, 4);
            this.buttonSelectCall.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSelectCall.Name = "buttonSelectCall";
            this.buttonSelectCall.Size = new System.Drawing.Size(161, 28);
            this.buttonSelectCall.TabIndex = 2;
            this.buttonSelectCall.Text = "Показать вызовы";
            this.buttonSelectCall.UseVisualStyleBackColor = true;
            this.buttonSelectCall.Click += new System.EventHandler(this.CallsButton_Click);
            // 
            // dateTimEnd
            // 
            this.dateTimEnd.CustomFormat = "";
            this.dateTimEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimEnd.Location = new System.Drawing.Point(304, 7);
            this.dateTimEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimEnd.Name = "dateTimEnd";
            this.dateTimEnd.Size = new System.Drawing.Size(265, 22);
            this.dateTimEnd.TabIndex = 1;
            this.dateTimEnd.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeStart.Location = new System.Drawing.Point(8, 7);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(265, 22);
            this.dateTimeStart.TabIndex = 0;
            this.dateTimeStart.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // buttonExportHTML1
            // 
            this.buttonExportHTML1.Location = new System.Drawing.Point(8, 492);
            this.buttonExportHTML1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportHTML1.Name = "buttonExportHTML1";
            this.buttonExportHTML1.Size = new System.Drawing.Size(352, 54);
            this.buttonExportHTML1.TabIndex = 17;
            this.buttonExportHTML1.Text = "Экспорт в HTML";
            this.buttonExportHTML1.UseVisualStyleBackColor = true;
            this.buttonExportHTML1.Click += new System.EventHandler(this.ButtonExportHTML_Click);
            // 
            // buttonExportExcel1
            // 
            this.buttonExportExcel1.Location = new System.Drawing.Point(410, 492);
            this.buttonExportExcel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExportExcel1.Name = "buttonExportExcel1";
            this.buttonExportExcel1.Size = new System.Drawing.Size(276, 54);
            this.buttonExportExcel1.TabIndex = 18;
            this.buttonExportExcel1.Text = "Экспорт в Excel";
            this.buttonExportExcel1.UseVisualStyleBackColor = true;
            this.buttonExportExcel1.Click += new System.EventHandler(this.ButtonExportExcel_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 640);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reports";
            this.Text = "Отчеты";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button unpaidInvoicesButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelContract;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExportExcel1;
        private System.Windows.Forms.Button buttonExportHTML1;
    }
}