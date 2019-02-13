using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Security_Agency
{
    public partial class MainForm : Form
    {
        private static bool itWasChangeUser = false;
        private AccessRoles _currentRole;           // уровень доступа
        private Authorization _link;
        private string _current_table = "";
        private bool itWasReplaceFKtoName = false;
        List<string> itemsForAutoComplete;

        public MainForm(AccessRoles role, Authorization link)
        {
            InitializeComponent();
            _currentRole = role;
            _link = link;
            itemsForAutoComplete = new List<string>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ButtonAdd.Enabled = false;
            this.ButtonEdit.Enabled = false;
            this.ButtonDelete.Enabled = false;
            this.ButtonUpdate.Enabled = false;
            listViewMessages.Enabled = false;
            labelMessages.Text = "";
        }
        /// <summary>
        /// Если condition false, показывает MessageBox с предупреждением
        /// </summary>
        /// <param name="condition">Условие, обозначющее, есть ли доступ у этого юзера</param>
        /// <returns>true, если messagebox был показан</returns>
        private bool NoAccessMessageBox(bool condition)
        {
            if (!condition)
            {
                MessageBox.Show("У вас нет прав для выполнения данной операции");
                return true;
            }
            return false;
        }
        //
        private bool CheckNoAccess()
        {
            bool no_access;
            switch (_current_table)
            {
                case "\"Client\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.Manager);
                    break;
                case "\"Contract\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.Manager);
                    break;
                case "\"Employee\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.HRManager);
                    break;
                case "\"Call\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.Inspector
                                                || _currentRole == AccessRoles.Dispatcher);
                    break;
                case "\"Invoice\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.Accountant);
                    break;
                case "\"Work_Equipment\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director
                                                || _currentRole == AccessRoles.Adjuster);
                    break;
                case "\"Position\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director);
                    break;
                case "\"Forfeit_Type\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director);
                    break;
                case "\"Payment_Type\"":
                    no_access = NoAccessMessageBox(_currentRole == AccessRoles.Director);
                    break;
                default:
                    no_access = false;
                    break;
            }
            return no_access;
        }
        // список клиентов
        public void ClientsList()
        {
            // select из таблицы Client 
            try
            {
                string currentTable = "\"Client\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Client\""] = "\"ID\"",
                    ["\"Surname\""] = "\"Фамилия\"",
                    ["\"Name\""] = "\"Имя\"",
                    ["\"Middle_Name\""] = "\"Отчество\"",
                    ["\"Passport_ID\""] = "\"Номер паспорта\"",
                    ["\"Date_Birth\""] = "\"Дата рождения\"",
                    ["\"Resident_Address\""] = "\"Адрес проживания\""
                }
                );
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // список договоров
        public void ContractsList()
        {
            try
            {
                string currentTable = "\"Contract\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Contract\""] = "\"ID\"",
                    ["\"Contract_ID\""] = "\"Номер договора\"",
                    ["\"Date_Contract\""] = "\"Дата заключения\"",
                    ["\"PK_Client\""] = "\"Клиент\"",
                    ["\"PK_Apartment\""] = "\"Квартира\"",
                    ["\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    row.Cells["Клиент"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", row.Cells["Клиент"].Value.ToString());
                    row.Cells["Квартира"].Value = Authorization.DBC.GetNameByFK("\"Address\"", "\"Apartment\"", row.Cells["Квартира"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                itWasReplaceFKtoName = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // список сотрудников
        public void EmployeesList()
        {
            try
            {
                string currentTable = "\"Employee\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Employee\""] = "\"ID\"",
                    ["\"Surname\""] = "\"Фамилия\"",
                    ["\"Name\""] = "\"Имя\"",
                    ["\"Middle_Name\""] = "\"Отчество\"",
                    ["\"Passport_ID\""] = "\"Номер паспорта\"",
                    ["\"INN\""] = "\"ИНН\"",
                    ["\"PK_Position\""] = "\"Должность\""
                }
                );
                itWasReplaceFKtoName = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    row.Cells["Должность"].Value = Authorization.DBC.GetNameByFK("\"Position_Title\"", "\"Position\"", row.Cells["Должность"].Value.ToString());
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                itWasReplaceFKtoName = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // список вызовов
        public void CallsList()
        {
            try
            {
                string currentTable = "\"Call\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Call\""] = "\"ID\"",
                    ["\"Call_Date\""] = "\"Дата вызова\"",
                    ["\"Time_Call\""] = "\"Время вызова\"",
                    ["\"Time_Arrive\""] = "\"Время прибытия экипажа\"",
                    ["\"False_Sign\""] = "\"Ложный вызов\"",
                    ["\"Hack_Sign\""] = "\"Был взлом\"",
                    ["\"PK_Apartment\""] = "\"Квартира\"",
                    ["\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    row.Cells["Был взлом"].Value = Config.TrueFalse[row.Cells["Был взлом"].Value.ToString()];
                    row.Cells["Ложный вызов"].Value = Config.TrueFalse[row.Cells["Ложный вызов"].Value.ToString()];
                    row.Cells["Квартира"].Value = Authorization.DBC.GetNameByFK("\"Address\"", "\"Apartment\"", row.Cells["Квартира"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // список счетов
        public void InvoicesList()
        {
            try
            {
                string currentTable = "\"Invoice\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Invoice\""] = "\"ID\"",
                    ["\"PK_Defrayal\""] = "\"Оплата\"",
                    ["\"Invoice_ID\""] = "\"Номер счета\"",
                    ["\"Date_Formation\""] = "\"Дата формирования\"",
                    ["\"Payment_State\""] = "\"Статус\"",
                    ["\"PK_Contract\""] = "\"Договор\"",
                    ["\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    row.Cells["Статус"].Value = Config.TrueFalseInvoice[row.Cells["Статус"].Value.ToString()];
                    string idClient = Authorization.DBC.GetPKByFK("\"PK_Client\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    string contractID = Authorization.DBC.GetPKByFK("\"Contract_ID\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    string client = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", idClient);
                    row.Cells["Договор"].Value = contractID + " " + client;
                    row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                }
                dataGridView.Columns["Оплата"].Visible = false;
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // список работ
        public void Work_EquipmentsList()
        {
            try
            {
                string currentTable = "\"Work_Equipment\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Work_Equipment\""] = "\"ID\"",
                    ["\"PK_Contract\""] = "\"Договор\"",
                    ["\"Name_Work\""] = "\"Наименование работы\"",
                    ["\"Approximate_Date\""] = "\"Планируемая дата проведения работ\"",
                    ["\"Work_Date\""] = "\"Дата выполнения\"",
                    ["\"Execution_Fact\""] = "\"Статус\"",
                    ["\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView.Rows[i];
                    row.Cells["Статус"].Value = Config.TrueFalseWork[row.Cells["Статус"].Value.ToString()];
                    string idClient = Authorization.DBC.GetPKByFK("\"PK_Client\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    string contractID = Authorization.DBC.GetPKByFK("\"Contract_ID\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    string client = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", idClient);
                    row.Cells["Договор"].Value = contractID + " " + client;
                    string pk = row.Cells["Сотрудник"].Value.ToString();
                    if (pk != "")
                    {
                        row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", pk);
                    }
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void PositionsList()
        {
            try
            {
                string currentTable = "\"Position\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Position\""] = "\"ID\"",
                    ["\"Position_Title\""] = "\"Наименование должности\""
                }
                );
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void Forfeit_TypesList()
        {
            try
            {
                string currentTable = "\"Forfeit_Type\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Forfeit_Type\""] = "\"ID\"",
                    ["\"Forfeit_name\""] = "\"Наименование штрафа\"",
                    ["\"Cost\""] = "\"Денежный размер\""
                }
                );
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void Payment_TypesList()
        {
            try
            {
                string currentTable = "\"Payment_Type\"";
                Authorization.DBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Payment_Type\""] = "\"ID\"",
                    ["\"Name_Type\""] = "\"Наименование\"",
                    ["\"Cost\""] = "\"Стоимость\""
                }
                );
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //??????????
        private void FillValuesToAutocomplete()
        {
            itemsForAutoComplete.Clear();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    itemsForAutoComplete.Add(cell.Value.ToString());
                }
            }
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(itemsForAutoComplete.ToArray());
            //this.TextBoxSearchPattern.AutoCompleteCustomSource = collection;
        }
        //
        void  MessagesList()
        {
            if(_currentRole == AccessRoles.Accountant)
            {
                labelMessages.Text = "Сообщения о неоплаченных счетах";
                listViewMessages.Clear();
                DataTable dataTable = new DataTable();
                List<string> tables = new List<string>();
                tables.Add("\"Invoice\"");
                tables.Add("\"Contract\"");
                tables.Add("\"Client\"");
                List<string> where = new List<string>();
                where.Add("\"Invoice\".\"PK_Contract\" = \"Contract\".\"PK_Contract\"");
                where.Add("\"Contract\".\"PK_Client\" = \"Client\".\"PK_Client\"");
                var adapter = Authorization.DBC.Select(tables, where,
                values: new Dictionary<string, string>()
                {
                    ["\"Invoice_ID\""] = "\"Номер счета\"",
                    ["\"Date_Formation\""] = "\"Дата формирования\"",
                    ["\"Payment_State\""] = "\"Статус\"",
                    ["\"Contract_ID\""] = "\"Номер договора\"",
                    ["\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\""] = "\"Клиент\""
                }
                );
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["Дата формирования"].ToString());
                    date = date.AddDays(3);
                    if (Convert.ToBoolean(row["Статус"].ToString()) == false && date < DateTime.Today)
                    {
                        string text ="Счет №" + row["Номер счета"].ToString() + " ";
                        text += " по договору №" + row["Номер договора"].ToString();
                        text += " на имя " + row["Клиент"].ToString();
                        text += " не был оплачен в срок до " + Convert.ToString(date);
                        listViewMessages.Items.Add(text);
                    }
                }
            }
            if(_currentRole == AccessRoles.Manager)
            {
                labelMessages.Text = "Сообщения о невыполненых работах";
                listViewMessages.Clear();
                DataTable dataTable = new DataTable();
                List <string> tables = new List<string>();
                tables.Add("\"Work_Equipment\"");
                tables.Add("\"Contract\"");
                tables.Add("\"Client\"");
                List<string> where = new List<string>();
                where.Add("\"Work_Equipment\".\"PK_Contract\" = \"Contract\".\"PK_Contract\"");
                where.Add("\"Contract\".\"PK_Client\" = \"Client\".\"PK_Client\"");
                var adapter = Authorization.DBC.Select(tables, where,
                values: new Dictionary<string, string>()
                {
                    ["\"Name_Work\""] = "\"Наименование работы\"",
                    ["\"Approximate_Date\""] = "\"Планируемая дата проведения работ\"",
                    ["\"Execution_Fact\""] = "\"Статус\"",
                    ["\"Contract_ID\""] = "\"Номер договора\"",
                    ["\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\""] = "\"Клиент\""
                }
                );
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    if (Convert.ToBoolean(row["Статус"].ToString()) == false && Convert.ToDateTime(row["Планируемая дата проведения работ"].ToString()) < DateTime.Today)
                    {
                        string text = row["Наименование работы"].ToString();
                        text += " по договору №" + row["Номер договора"].ToString();
                        text += " на имя " + row["Клиент"].ToString();
                        text += " не была выполнена в срок до " + row["Планируемая дата проведения работ"].ToString();
                        listViewMessages.Items.Add(text);
                    }
                }
            }
        }
        //
        private int GetSelectedRow()
        {
            int index;
            try
            {
                index = dataGridView.CurrentCell.RowIndex;
            }
            catch (Exception)
            {
                index = -1;
            }
            return index;
        }
        //Обновляем текущую таблицу
        private void UpdateTable()
        {
            Type t = this.GetType();
            string str = _current_table.Substring(1, _current_table.Length - 2) + "sList";
            MethodInfo method = t.GetMethod(str);
            method.Invoke(this, null);
        }
        //вызывает метод вида <tableName>List
        private void ChangeCurrentContext(object sender, EventArgs e)
        {
            this.ButtonAdd.Enabled = true;
            this.ButtonEdit.Enabled = true;
            this.ButtonDelete.Enabled = true;
            this.ButtonUpdate.Enabled = true;
            this.LabelQueryInfo.Text = sender.ToString();
            Type t = this.GetType();
            MethodInfo method = t.GetMethod(Config.methodTranslate[sender.ToString()] + "List");
            method.Invoke(this, null);
            MessagesList();
        }
        // смена пользователя
        private void ChangeUser(object sender, EventArgs e)
        {
            itWasChangeUser = true;
            _link.Reset();
            Close();
            itWasChangeUser = false;
        }
        //
        private void ReportsTSMI_Click(object sender, EventArgs e)
        {
            new Reports().Show();
        }
        //вызывает форму вида Add<formName>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (CheckNoAccess())
                return;
            string nameForm = "Add" + _current_table.Substring(1, _current_table.Length - 2);
            try
            {
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this) as Form;
                form.ShowDialog();
                UpdateTable();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        //вызывает форму вида Add<formName> для редактирования
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (CheckNoAccess())
                return;
            int curRow = GetSelectedRow();
            if (curRow == -1)
            {
                MessageBox.Show("Сначала выберите запись для рекдатирования.");
                return;
            }
            Config.valueFromTableForEdit.Clear();
            foreach (DataGridViewCell cell in dataGridView.Rows[curRow].Cells)
            {
                Config.valueFromTableForEdit.Add(cell.OwningColumn.Name, cell.Value.ToString());
            }
            string nameForm = "Add" + _current_table.Substring(1, _current_table.Length - 2);
            try
            {
                Config.CurrentIndex = Convert.ToInt32(dataGridView["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                UpdateTable();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }        
        }
        //
        private void ButtonDelete_Click(object sendet, EventArgs e)
        {
            if (CheckNoAccess())
                return;
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow();
            if (index == -1 || _current_table == "")
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridView["ID", index].Value.ToString();
                switch (_current_table)
                {
                    case "\"Client\"":
                        Authorization.DBC.Delete("\"Client\"", new Tuple<string, string>("\"PK_Client\"", id));
                        ClientsList();
                        break;
                    case "\"Contract\"":
                        Authorization.DBC.Delete("\"Contract\"", new Tuple<string, string>("\"PK_Contract\"", id));
                        ContractsList();
                        break;
                    case "\"Employee\"":
                        Authorization.DBC.Delete("\"Employee\"", new Tuple<string, string>("\"PK_Employee\"", id));
                        EmployeesList();
                        break;
                    case "\"Call\"":
                        Authorization.DBC.Delete("\"Call\"", new Tuple<string, string>("\"PK_Call\"", id));
                        CallsList();
                        break;
                    case "\"Invoice\"":
                        Authorization.DBC.Delete("\"Invoice\"", new Tuple<string, string>("\"PK_Invoice\"", id));
                        InvoicesList();
                        break;
                    case "\"Work_Equipment\"":
                        Authorization.DBC.Delete("\"Work_Equipment\"", new Tuple<string, string>("\"PK_Work_Equipment\"", id));
                        Work_EquipmentsList();
                        break;
                    case "\"Position\"":
                        Authorization.DBC.Delete("\"Position\"", new Tuple<string, string>("\"PK_Position\"", id));
                        InvoicesList();
                        break;
                    case "\"Forfeit_Type\"":
                        Authorization.DBC.Delete("\"Forfeit_Type\"", new Tuple<string, string>("\"PK_Forfeit_Type\"", id));
                        InvoicesList();
                        break;
                    case "\"Payment_Type\"":
                        Authorization.DBC.Delete("\"Payment_Type\"", new Tuple<string, string>("\"PK_Payment_Type\"", id));
                        InvoicesList();
                        break;
                    default:
                        throw new Exception("Неправильная указана текущая таблица: " + _current_table);
                }
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
        //
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        // Закрытие приложения
        private void OnClose(object sender, FormClosedEventArgs e)
        {
            if (!itWasChangeUser)
                _link.Close();
        }
        // поиск
        private void Search(object sender, EventArgs e)
        {
            if (searchPatternTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пустой поисковый запрос");
                return;
            }
            string searchPattern = searchPatternTextBox.Text;
            DataGridView table = new DataGridView();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                table.Columns.Add(column.Clone() as DataGridViewColumn);
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int indexT = table.Rows.Add();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    table.Rows[indexT].Cells[i].Value = row.Cells[i].Value;
                }
            }
            //вставим в таблицу те же столбцы, что в той, в которой ищем
            int index = 0;
            // теперь произведем поиск
            foreach (DataGridViewRow row in table.Rows)
            {
                bool isGood = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        string value = cell.Value.ToString();
                        // если хотя бы один столбцец строки соответствует паттерну,
                        // вставим эту строку в результат поиска
                        if (value.ToLower().Contains(searchPattern.ToLower()))
                        {
                            isGood = true;
                            break;
                        }
                    }
                    catch (NullReferenceException)
                    {
                        break;
                    }
                }
                if (isGood)
                {
                    //int index = dataGridView.Rows.Add();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        dataGridView.Rows[index].Cells[i].Value = row.Cells[i].Value;
                    }
                    index++;
                }
            }
            while(index < dataGridView.Rows.Count)
            {
                dataGridView.Rows.Remove(dataGridView.Rows[index]);
            }
        }
    }
}
