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
        //private delegate void CurrentFunction(object sender, EventArgs e);
        //private CurrentFunction _currFunc = null;
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
            //IntPtr hMenu = GetSystemMenu(Handle, false);
            //int menuItemCount = GetMenuItemCount(hMenu);
            //RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);

            /*if (_currentRole != AccessRoles.Director)
                this.ToogleRawEditButton.Enabled = false;

            ToogleRawEditButton.Dispose();
            this.LabelUsername.Text = "Пользователь: " + Authorization.login;

            this.queryInfoLabel.Text = "Клиенты";
            ClientsList();*/
        }

        
        // список клиентов
        public void ClientsList()
        {
            // select из таблицы Client 
            try
            {
                string currentTable = "\"Client\"";
                Authorization.DBC.Select(currentTable, tableView: DataGridView,
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
                //FillValuesToAutocomplete();
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
                Authorization.DBC.Select(currentTable, tableView: DataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"PK_Contract\""] = "\"ID\"",
                    ["\"Contract_ID\""] = "\"Номер контракта\"",
                    ["\"Date_Contract\""] = "\"Дата заключения\"",
                    ["\"PK_Client\""] = "\"Клиент\"",
                    ["\"PK_Apartment\""] = "\"Квартира\"",
                    ["\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                for(int i = 0; i < DataGridView.Rows.Count-1; i++)
                {
                    DataGridViewRow row = DataGridView.Rows[i];
                    row.Cells["Клиент"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", row.Cells["Клиент"].Value.ToString());
                    row.Cells["Квартира"].Value = Authorization.DBC.GetNameByFK("\"Address\"", "\"Apartment\"", row.Cells["Квартира"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                //FillValuesToAutocomplete();
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
                Authorization.DBC.Select(currentTable, tableView: DataGridView,
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
                for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = DataGridView.Rows[i];
                    row.Cells["Должность"].Value = Authorization.DBC.GetNameByFK("\"Position_Title\"", "\"Position\"", row.Cells["Должность"].Value.ToString());
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
               // FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                itWasReplaceFKtoName = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }


      /*  /// <summary>
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
        }*/

       /* private bool CheckNoAccess()
        {
            bool no_access;
            switch (_current_table)
            {
                case "\"Client\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Manager
                    );
                    break;
                case "\"Contract\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Manager
                    );
                    break;
                case "\"Employee\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Manager
                    );
                    break;
                case "\"Payment\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Accountant
                    );
                    break;
                case "\"Fine\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Accountant
                    );
                    break;
                case "\"Call\"":
                    no_access = NoAccessMessageBox(
                        _currentRole == AccessRoles.Director
                        || _currentRole == AccessRoles.Inspector
                        || _currentRole == AccessRoles.Dispatcher
                    );
                    break;
                default:
                    no_access = false;
                    break;
            }
            return no_access;
        }*/   

        // поиск
       /* private void Search(object sender, EventArgs e)
        {
            if (searchPatternTextBox.Text.Length == 0)
            {
                MessageBox.Show("Пустой поисковый запрос");
                return;
            }
            SearchResult search = new SearchResult();
            search.Show();
            search.MakeSearch(searchPatternTextBox.Text, dataGridView);
        }*/

        /*private void topLevelExit_Click(object sender, EventArgs e)
        {
            _link.Close();
        }*/

       /* private List<string> GetRowValues(int id)
        {
            List<string> values = new List<string>();
            foreach (DataGridViewCell cell in dataGridView.Rows[id].Cells)
            {
                values.Add(cell.Value.ToString());
            }
            return values;
        }*/

        //TODO: Добавить словари для остальных таблиц
       /* public List<string> GetTableColumnsName(string table)
        {
            List<string> names = new List<string>();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (_current_table == "\"Client\"") //TODO: Добавить русские названия
                    names.Add(Config.clientEnglishColumns[column.Name]);
                else
                    names.Add(column.Name);
            }
            return names;
        }*/

        //??????????
        private void FillValuesToAutocomplete()
        {
            itemsForAutoComplete.Clear();
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    itemsForAutoComplete.Add(cell.Value.ToString());
                }
            }
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(itemsForAutoComplete.ToArray());
            this.TextBoxSearchPattern.AutoCompleteCustomSource = collection;
        }

        //Обновление записи в таблице через DataGridView
       /* private void UpdateEntry()
        {
            if (CheckNoAccess())
                return;
            int index = GetSelectedRow();
            if (index == -1 || _current_table == "")
            {
                MessageBox.Show("Необходимо выбрать запись.");
                return;
            }
            try
            {
                string id = dataGridView["ID", index].Value.ToString();
                //TODO: Можно объединить в словарь
                List<string> columnNames = GetTableColumnsName(_current_table);
                List<string> columnValues = GetRowValues(index);
                Authorization.ODBC.Update(_current_table, id, columnNames, columnValues);
                // _currFunc(null, null);
                MessageBox.Show("Запись успешно обновлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

       /* public void PaymentsList()
        {
            try
            {
                string currentTable = "\"Payment\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Payment_date\""] = "\"Дата\"",
                    ["\"Payment_sum\""] = "\"Сумма\"",
                    ["\"ID_invoice_type\""] = "\"Тип платежа\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_accountant\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells["Тип платежа"].Value = Authorization.ODBC.getNameByFK("\"Name\"", "\"InvoiceType\"", row.Cells["Тип платежа"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                    string id_client = Authorization.ODBC.getNameByFK("\"ID_client\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    row.Cells["Договор"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", id_client);
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

       /* public void FinesList()
        {
            try
            {
                string currentTable = "\"Fine\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Date\""] = "\"Дата\"",
                    ["\"Sum\""] = "\"Сумма\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_type_fine\""] = "\"Тип\"",
                    ["\"ID_accountant\""] = "\"Сотрудник\""
                }
                );
                itWasReplaceFKtoName = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells["Тип"].Value = Authorization.ODBC.getNameByFK("\"Name\"", "\"FineType\"", row.Cells["Тип"].Value.ToString());
                    row.Cells["Сотрудник"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Employee\"", row.Cells["Сотрудник"].Value.ToString());
                    string id_client = Authorization.ODBC.getNameByFK("\"ID_client\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    row.Cells["Договор"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", id_client);
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

       /* public void CallsList()
        {
            try
            {
                string currentTable = "\"Call\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Date\""] = "\"Дата\"",
                    ["\"Call_time\""] = "\"Время\"",
                    ["\"Arrival_time\""] = "\"Время прибытия экипажа\"",
                    ["\"Is_false_call\""] = "\"Ложный вызов\"",
                    ["\"Is_hacked\""] = "\"Был взлом\"",
                    ["\"Contract_ID\""] = "\"Договор\"",
                    ["\"ID_bossfight_thiscall\""] = "\"Начальник наряда\"",
                    ["\"ID_dispatcher_thiscall\""] = "\"Диспетчер\""
                }
                );
                itWasReplaceFKtoName = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string idDisp = Authorization.ODBC.getNameByFK("\"ID_dispatcher\"", "\"DispatcherThisCall\"", row.Cells["Диспетчер"].Value.ToString());
                    string idBoss = Authorization.ODBC.getNameByFK("\"ID_bossfight\"", "\"BossFightThisCall\"", row.Cells["Начальник наряда"].Value.ToString());

                    row.Cells["Начальник наряда"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Employee\"", idBoss);
                    row.Cells["Диспетчер"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Employee\"", idDisp);


                    row.Cells["Был взлом"].Value = Config.TrueFalse[row.Cells["Был взлом"].Value.ToString()];
                    row.Cells["Ложный вызов"].Value = Config.TrueFalse[row.Cells["Ложный вызов"].Value.ToString()];
                    string id_client = Authorization.ODBC.getNameByFK("\"ID_client\"", "\"Contract\"", row.Cells["Договор"].Value.ToString());
                    row.Cells["Договор"].Value = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", id_client);
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

        // украденные вещи
       /* public void Stolen_stuffssList()
        {
            try
            {
                string currentTable = "\"Stolen_stuffs\"";
                Authorization.ODBC.Select(currentTable, tableView: dataGridView,
                values: new Dictionary<string, string>()
                {
                    ["\"ID\""] = "\"ID\"",
                    ["\"Name\""] = "\"Наименование\"",
                    ["\"Price\""] = "\"Цена\"",
                    ["\"Amount\""] = "\"Количество\"",
                    ["\"Call_ID\""] = "\"Сигнал тревоги\""
                }
                );
                itWasReplaceFKtoName = true;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string contract_id_time = Authorization.ODBC.getNameByFK("\"Contract_ID\" || '_' || TO_CHAR(\"Date\", 'DD.MM.YYYY')", "\"Call\"", row.Cells["Сигнал тревоги"].Value.ToString());
                    string contract_id = contract_id_time.Split('_')[0];
                    string time = contract_id_time.Split('_')[1];
                    string client_id = Authorization.ODBC.getNameByFK("\"ID_client\"", "\"Contract\"", contract_id);
                    string fio = Authorization.ODBC.getNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Otch\"", "\"Client\"", client_id);
                    row.Cells["Сигнал тревоги"].Value = fio + " " + time;
                }
                itWasReplaceFKtoName = false;
                _current_table = currentTable;
                FillValuesToAutocomplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/

       /* private void ToogleRawEditSwitch(object sender, EventArgs e)
        {
            this.dataGridView.ReadOnly = !this.dataGridView.ReadOnly;
        }*/

       /* private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!itWasReplaceFKtoName)
                UpdateEntry();
        }*/


        //
        private int GetSelectedRow()
        {
            int index;
            try
            {
                index = DataGridView.CurrentCell.RowIndex;
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
        }

        /*private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reports().Show();
        }*/
        // смена пользователя
        private void ChangeUser(object sender, EventArgs e)
        {
            itWasChangeUser = true;
            _link.Reset();
            Close();
            itWasChangeUser = false;
        }

        //вызывает форму вида Add<formName>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string nameForm = "Add" + _current_table.Substring(1, _current_table.Length - 2);
            try
            {
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this) as Form;
                form.Show();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        //вызывает форму вида Add<formName> для редактирования
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int curRow = GetSelectedRow();
            if (curRow == -1)
            {
                MessageBox.Show("Сначала выберите запись для рекдатирования.");
                return;
            }
            Config.valueFromTableForEdit.Clear();
            foreach (DataGridViewCell cell in DataGridView.Rows[curRow].Cells)
            {
                Config.valueFromTableForEdit.Add(cell.OwningColumn.Name, cell.Value.ToString());
            }
            string nameForm = "Add" + _current_table.Substring(1, _current_table.Length - 2);
            try
            {
                Config.CurrentIndex = Convert.ToInt32(DataGridView["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this) as Form;
                form.Text = "Редактирование";
                form.Show();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }        
        }
        //
        private void ButtonDelete_Click(object sendet, EventArgs e)
        {
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
                string id = DataGridView["ID", index].Value.ToString();
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
                    /*case "\"Payment\"":
                        Authorization.DBC.Delete("\"Payment\"", new Tuple<string, string>("\"ID\"", id));
                        PaymentsList();
                        break;
                    case "\"Fine\"":
                        Authorization.DBC.Delete("\"Fine\"", new Tuple<string, string>("\"ID\"", id));
                        FinesList();
                        break;
                    case "\"Call\"":
                        Authorization.DBC.Delete("\"Call\"", new Tuple<string, string>("\"ID\"", id));
                        CallsList();
                        break;*/
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
    }
}
