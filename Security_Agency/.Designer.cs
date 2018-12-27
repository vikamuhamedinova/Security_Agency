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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.LabelQueryInfo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функционалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithClientsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithСontractsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkWithEmployeeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUserTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxSearchPattern = new System.Windows.Forms.TextBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(701, 479);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(134, 54);
            this.ButtonEdit.TabIndex = 2;
            this.ButtonEdit.Text = "Редактировать";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(545, 479);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(134, 54);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 76);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1228, 365);
            this.DataGridView.TabIndex = 0;
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
            this.отчетыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функционалToolStripMenuItem
            // 
            this.функционалToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workWithClientsTSMI,
            this.workWithСontractsTSMI,
            this.WorkWithEmployeeTSMI,
            this.вызовыToolStripMenuItem});
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
            // вызовыToolStripMenuItem
            // 
            this.вызовыToolStripMenuItem.Name = "вызовыToolStripMenuItem";
            this.вызовыToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.вызовыToolStripMenuItem.Text = "Сигналы тревоги";
            this.вызовыToolStripMenuItem.Click += new System.EventHandler(this.ChangeCurrentContext);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
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
            this.ButtonDelete.Location = new System.Drawing.Point(858, 479);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(134, 54);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxSearchPattern
            // 
            this.TextBoxSearchPattern.Location = new System.Drawing.Point(12, 511);
            this.TextBoxSearchPattern.Name = "TextBoxSearchPattern";
            this.TextBoxSearchPattern.Size = new System.Drawing.Size(250, 22);
            this.TextBoxSearchPattern.TabIndex = 5;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(1012, 479);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(134, 54);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "Обновить";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 567);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.TextBoxSearchPattern);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.LabelQueryInfo);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Охранное агенство";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label LabelQueryInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функционалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workWithClientsTSMI;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxSearchPattern;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.ToolStripMenuItem workWithСontractsTSMI;
        private System.Windows.Forms.ToolStripMenuItem WorkWithEmployeeTSMI;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserTSMI;
        private System.Windows.Forms.ToolStripMenuItem вызовыToolStripMenuItem;
    }
}

