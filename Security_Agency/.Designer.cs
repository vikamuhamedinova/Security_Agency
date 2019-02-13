namespace Security_Agency
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LabelQueryInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithClientsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithСontractsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithEmployeeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithCallTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithInvoicesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.forfeitTypeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentTypeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUserTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.labelMessages = new System.Windows.Forms.Label();
            this.searchPatternTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(1106, 615);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(134, 54);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Редактировать";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(1106, 555);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(134, 54);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 76);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView.RowTemplate.Height = 26;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(1228, 365);
            this.dataGridView.TabIndex = 1;
            // 
            // LabelQueryInfo
            // 
            this.LabelQueryInfo.AutoSize = true;
            this.LabelQueryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQueryInfo.Location = new System.Drawing.Point(9, 39);
            this.LabelQueryInfo.Name = "LabelQueryInfo";
            this.LabelQueryInfo.Size = new System.Drawing.Size(0, 18);
            this.LabelQueryInfo.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функционалToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.reportsTSMI,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функционалToolStripMenuItem
            // 
            this.функционалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workWithClientsTSMI,
            this.workWithСontractsTSMI,
            this.WorkWithEmployeeTSMI,
            this.WorkWithCallTSMI,
            this.WorkWithInvoicesTSMI,
            this.WorkTSMI});
            this.функционалToolStripMenuItem.Name = "функционалToolStripMenuItem";
            this.функционалToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.функционалToolStripMenuItem.Text = "Функционал";
            // 
            // workWithClientsTSMI
            // 
            this.workWithClientsTSMI.Name = "workWithClientsTSMI";
            this.workWithClientsTSMI.Size = new System.Drawing.Size(246, 26);
            this.workWithClientsTSMI.Text = "Работа с клиентами";
            this.workWithClientsTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // workWithСontractsTSMI
            // 
            this.workWithСontractsTSMI.Name = "workWithСontractsTSMI";
            this.workWithСontractsTSMI.Size = new System.Drawing.Size(246, 26);
            this.workWithСontractsTSMI.Text = "Работа с договорами";
            this.workWithСontractsTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // WorkWithEmployeeTSMI
            // 
            this.WorkWithEmployeeTSMI.Name = "WorkWithEmployeeTSMI";
            this.WorkWithEmployeeTSMI.Size = new System.Drawing.Size(246, 26);
            this.WorkWithEmployeeTSMI.Text = "Работа с сотрудниками";
            this.WorkWithEmployeeTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // WorkWithCallTSMI
            // 
            this.WorkWithCallTSMI.Name = "WorkWithCallTSMI";
            this.WorkWithCallTSMI.Size = new System.Drawing.Size(246, 26);
            this.WorkWithCallTSMI.Text = "Сигналы тревоги";
            this.WorkWithCallTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // WorkWithInvoicesTSMI
            // 
            this.WorkWithInvoicesTSMI.Name = "WorkWithInvoicesTSMI";
            this.WorkWithInvoicesTSMI.Size = new System.Drawing.Size(246, 26);
            this.WorkWithInvoicesTSMI.Text = "Работа со счетами";
            this.WorkWithInvoicesTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // WorkTSMI
            // 
            this.WorkTSMI.Name = "WorkTSMI";
            this.WorkTSMI.Size = new System.Drawing.Size(246, 26);
            this.WorkTSMI.Text = "Работы";
            this.WorkTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionsTSMI,
            this.forfeitTypeTSMI,
            this.paymentTypeTSMI});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // positionsTSMI
            // 
            this.positionsTSMI.Name = "positionsTSMI";
            this.positionsTSMI.Size = new System.Drawing.Size(192, 26);
            this.positionsTSMI.Text = "Должности";
            this.positionsTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // forfeitTypeTSMI
            // 
            this.forfeitTypeTSMI.Name = "forfeitTypeTSMI";
            this.forfeitTypeTSMI.Size = new System.Drawing.Size(192, 26);
            this.forfeitTypeTSMI.Text = "Типы штрафов";
            this.forfeitTypeTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // paymentTypeTSMI
            // 
            this.paymentTypeTSMI.Name = "paymentTypeTSMI";
            this.paymentTypeTSMI.Size = new System.Drawing.Size(192, 26);
            this.paymentTypeTSMI.Text = "Типы платежей";
            this.paymentTypeTSMI.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // reportsTSMI
            // 
            this.reportsTSMI.Name = "reportsTSMI";
            this.reportsTSMI.Size = new System.Drawing.Size(71, 24);
            this.reportsTSMI.Text = "Отчеты";
            this.reportsTSMI.Click += new System.EventHandler(this.ReportsTSMI_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeUserTSMI});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // ChangeUserTSMI
            // 
            this.ChangeUserTSMI.Name = "ChangeUserTSMI";
            this.ChangeUserTSMI.Size = new System.Drawing.Size(244, 26);
            this.ChangeUserTSMI.Text = "Сменить пользователя";
            this.ChangeUserTSMI.Click += new System.EventHandler(this.ChangeUser);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(1106, 675);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(134, 54);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(1106, 495);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(134, 54);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // listViewMessages
            // 
            this.listViewMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMessages.Location = new System.Drawing.Point(15, 555);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(1059, 174);
            this.listViewMessages.TabIndex = 7;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            this.listViewMessages.View = System.Windows.Forms.View.List;
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(12, 532);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(46, 17);
            this.labelMessages.TabIndex = 8;
            this.labelMessages.Text = "label1";
            // 
            // searchPatternTextBox
            // 
            this.searchPatternTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchPatternTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchPatternTextBox.Location = new System.Drawing.Point(12, 484);
            this.searchPatternTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchPatternTextBox.Name = "searchPatternTextBox";
            this.searchPatternTextBox.Size = new System.Drawing.Size(267, 22);
            this.searchPatternTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(335, 479);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(99, 32);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.Search);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 748);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPatternTextBox);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelQueryInfo);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Охранное агенство";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label LabelQueryInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workWithClientsTSMI;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.ToolStripMenuItem workWithСontractsTSMI;
        private System.Windows.Forms.ToolStripMenuItem WorkWithEmployeeTSMI;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsTSMI;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserTSMI;
        private System.Windows.Forms.ToolStripMenuItem WorkWithCallTSMI;
        private System.Windows.Forms.ToolStripMenuItem WorkWithInvoicesTSMI;
        private System.Windows.Forms.ToolStripMenuItem positionsTSMI;
        private System.Windows.Forms.ToolStripMenuItem forfeitTypeTSMI;
        private System.Windows.Forms.ToolStripMenuItem paymentTypeTSMI;
        private System.Windows.Forms.ToolStripMenuItem WorkTSMI;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.TextBox searchPatternTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

