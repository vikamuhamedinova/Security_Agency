using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Agency
{
    public partial class AddContract : Form
    { 
        private MainForm mainForm;
        private List<int> apartIDs = new List<int>(),
                          emplIDs = new List<int>(),
                          clientIDs = new List<int>();
        private string pkContract;

        //
        public AddContract()
        {
            InitializeComponent();
            FillForm();
        }
        //
        public AddContract(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }
        // Заполнение формы при старте
        private void FillForm()
        {
            ClearForm();
            UpdateComboBoxies();
        }
        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void UpdateComboBoxies()
        {
            // Очищаем все комбоБоксы
            comboBoxAddClient.Items.Clear();
            comboBoxAddApartment.Items.Clear();
            comboBoxAddEmployee.Items.Clear();
            // И список ключей
            apartIDs.Clear();
            emplIDs.Clear();
            clientIDs.Clear();
            // Заполняем данными все комбоБоксы
            // Квартиры
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"Apartment\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Apartment\""] = "ID",
                                                            ["\"Address\""] = "Адрес"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    apartIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxAddApartment.Items.Add(row["Адрес"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
            // Сотрудники
            try
            {
                currentTable = "\"Employee\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Employee\""] = "ID",
                                                            ["\"Surname\""] = "Фамилия",
                                                            ["\"Name\""] = "Имя",
                                                            ["\"Middle_Name\""] = "Отчество",
                                                            ["\"PK_Position\""] = "Position_ID"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string positionTitle = Authorization.DBC.GetNameByFK("\"Position_Title\"", "\"Position\"", row["Position_ID"].ToString());
                    if (positionTitle != "Сотрудник отдела по работе с клиентами") //если не сотрудник отдела по работе с клиентами
                        continue;
                    emplIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxAddEmployee.Items.Add(
                          row["Фамилия"].ToString() + " "
                        + row["Имя"].ToString() + " "
                        + row["Отчество"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
            // Клиенты
            try
            {
                currentTable = "\"Client\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Client\""] = "ID",
                                                            ["\"Surname\""] = "Фамилия",
                                                            ["\"Name\""] = "Имя",
                                                            ["\"Middle_Name\""] = "Отчество"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    clientIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxAddClient.Items.Add(
                          row["Фамилия"].ToString() + " "
                        + row["Имя"].ToString() + " "
                        + row["Отчество"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dataTable.Clear();
        }
        //
        private void ClearForm()
        {
            maskedTextBoxContractIdInput.Text = "";
            dateTimeInputContract.Text = "01.01.2000";
        }
        //
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
        }
        // преобразование к дате
        private string ConvertToDateDB(string text)
        {
            return String.Format("TO_DATE('{0}','DD.MM.YYYY')", text);
        }
        // убирает все пустые значения, выполняет преобразования к строке
        private Dictionary<string, string> PrepareData(Dictionary<string, string> vals)
        {
            IList<string> keysToRemove = new List<string>();
            foreach (var pair in vals)
            {
                if (vals[pair.Key] == "")
                    keysToRemove.Add(pair.Key);
            }
            foreach (var key in keysToRemove)
            {
                vals.Remove(key);
            }
            if (vals["\"Date_Contract\""] == "  .  .")
            {
                vals.Remove("\"Date\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));
                }
                else
                {
                    newDict.Add(key, ConvertToStringDB(vals[key]));
                }
            }
            return newDict;
        }
        //
        private int GetSelectedRow(DataGridView dataGridView)
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
        //
        public void PropertyList()
        {
            try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Property\"");
                tables.Add("\"Property_List\"");
                string where = Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex]);
                Authorization.DBC.SelectW(tables, where, "Apartment", tableView: dataGridViewProperty,
                values: new Dictionary<string, string>()
                {
                    ["\"Property_List\".\"PK_Property_List\""] = "\"ID\"",
                    ["\"Property_List\".\"PK_Apartment\""] = "\"Адрес\"",
                    ["\"Property_List\".\"PK_Property\""] = "\"Наименование\"",
                    ["\"Property\".\"Property_Cost\""] = "\"Стоимость\""
                }
                );
                dataGridViewProperty.Columns["ID"].Visible = false;
                dataGridViewProperty.Columns["Адрес"].Visible = false;
                for (int i = 0; i < dataGridViewProperty.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewProperty.Rows[i];
                    string pk = row.Cells["Наименование"].Value.ToString();
                    row.Cells["Наименование"].Value = Authorization.DBC.GetNameByFK("\"Property_Name\"", "\"Property\"", pk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void ResidentList()
        {
            try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Resident\"");
                tables.Add("\"List_Resident\"");
                string where = Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex]);
                Authorization.DBC.SelectW(tables, where, "Apartment", tableView: dataGridViewResident,
                values: new Dictionary<string, string>()
                {
                    ["\"List_Resident\".\"PK_List_Resident\""] = "\"ID\"",
                    ["\"List_Resident\".\"PK_Apartment\""] = "\"Адрес\"",
                    ["\"List_Resident\".\"PK_Resident\""] = "\"Фамилия\"",
                    ["\"Resident\".\"Name\""] = "\"Имя\"",
                    ["\"Resident\".\"Middle_Name\""] = "\"Отчество\"",
                    ["\"Resident\".\"Passport_ID\""] = "\"Номер паспорта\"",
                    ["\"Resident\".\"Date_Birth\""] = "\"Дата рождения\""
                }
                );
                dataGridViewResident.Columns["Адрес"].Visible = false;
                for (int i = 0; i < dataGridViewResident.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewResident.Rows[i];
                    string pk = row.Cells["Фамилия"].Value.ToString();
                    row.Cells["Фамилия"].Value = Authorization.DBC.GetNameByFK("\"Surname\"", "\"Resident\"", pk);
                }
                dataGridViewResident.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void WorkEquipList()
        {
            try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Contract\"");
                tables.Add("\"Work_Equipment\"");
                Authorization.DBC.SelectPK(tables, pkContract, tableView: dataGridViewWorkEquip,
                values: new Dictionary<string, string>()
                {
                    ["\"Work_Equipment\".\"PK_Work_Equipment\""] = "\"ID\"",
                    ["\"Work_Equipment\".\"PK_Contract\""] = "\"Договор\"",
                    ["\"Work_Equipment\".\"Name_Work\""] = "\"Наименование работы\"",
                    ["\"Work_Equipment\".\"Approximate_Date\""] = "\"Планируемая дата проведения работ\"",
                    ["\"Work_Equipment\".\"Work_Date\""] = "\"Дата выполнения\"",
                    ["\"Work_Equipment\".\"Execution_Fact\""] = "\"Статус\"",
                    ["\"Work_Equipment\".\"PK_Employee\""] = "\"Сотрудник\""
                }
                );
                dataGridViewWorkEquip.Columns["Договор"].Visible = false;
                for (int i = 0; i < dataGridViewWorkEquip.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewWorkEquip.Rows[i];
                    row.Cells["Статус"].Value = Config.TrueFalseWork[row.Cells["Статус"].Value.ToString()];
                    string pk = row.Cells["Сотрудник"].Value.ToString();
                    if(pk != "")
                        row.Cells["Сотрудник"].Value = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Employee\"", pk);
                }
                dataGridViewWorkEquip.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        // Загрузка формы
        private void AddContract_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddContract.Text = "Сохранить";
                pkContract = Config.valueFromTableForEdit["ID"];
                maskedTextBoxContractIdInput.Text = Config.valueFromTableForEdit["Номер договора"];
                dateTimeInputContract.Text = Config.valueFromTableForEdit["Дата заключения"];
                comboBoxAddClient.SelectedIndex = comboBoxAddClient.FindStringExact(Config.valueFromTableForEdit["Клиент"]);
                comboBoxAddApartment.SelectedIndex = comboBoxAddApartment.FindStringExact(Config.valueFromTableForEdit["Квартира"]);
                comboBoxAddEmployee.SelectedIndex = comboBoxAddEmployee.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                PropertyList();
                ResidentList();
                WorkEquipList();
            }
            else
            {
                FillForm();
                buttonAddWorkEquip.Enabled = false;
                buttonEditWorkEquip.Enabled = false;
                buttonDeleteWorkEquip.Enabled = false;
            }
        }
        // Добавление договора
        private void ButtonAddContract_Click(object sender, EventArgs e)
        {
            if  ((comboBoxAddClient.SelectedIndex == -1) ||
                (comboBoxAddApartment.SelectedIndex == -1) ||
                (comboBoxAddEmployee.SelectedIndex == -1))
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Contract_ID\""] = maskedTextBoxContractIdInput.Text,
                    ["\"Date_Contract\""] = dateTimeInputContract.Text,
                    ["\"PK_Client\""] = Convert.ToString(clientIDs[comboBoxAddClient.SelectedIndex]),
                    ["\"PK_Apartment\""] = Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex]),
                    ["\"PK_Employee\""] = Convert.ToString(emplIDs[comboBoxAddEmployee.SelectedIndex])
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Contract\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Договор была обновлена.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Contract\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToStringDB(maskedTextBoxContractIdInput.Text);
                        ///
                        var adapter = Authorization.DBC.SelectPK("\"Contract\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Contract\""] = "ID"
                                                                });
                        ///
                        adapter.Fill(dataTable);
                        DataRow row = dataTable.Rows[0];
                        pkContract = row["ID"].ToString();

                        MessageBox.Show("Договор добавлен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                buttonAddWorkEquip.Enabled = true;
                buttonEditWorkEquip.Enabled = true;
                buttonDeleteWorkEquip.Enabled = true;
            }
        }
        //
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Отмена 
        private void ButtonCancelAddContract_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        // Добавление квартиры
        private void ButtonAddApartment_Click(object sender, EventArgs e)
        {
            new AddApartment().ShowDialog(this);
            UpdateComboBoxies();
        }
        // Добавление имущества
        private void ButtonAddProperty_Click(object sender, EventArgs e)
        {
            if(comboBoxAddApartment.SelectedIndex != -1)
            {
                new AddProperty(this,Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])).ShowDialog();
                PropertyList();
            }
            else
            {
                MessageBox.Show("Не заполнено поле Квартира");
            }
        }
        // Редактирование имущества
        private void ButtonEditProperty_Click(object sender, EventArgs e)
        {
            int curRow = GetSelectedRow(dataGridViewProperty);
            if (curRow == -1)
            {
                MessageBox.Show("Сначала выберите запись для рекдатирования.");
                return;
            }
            Config.valueFromTableForEdit.Clear();
            foreach (DataGridViewCell cell in dataGridViewProperty.Rows[curRow].Cells)
            {
                Config.valueFromTableForEdit.Add(cell.OwningColumn.Name, cell.Value.ToString());
            }
            string nameForm = "AddProperty";
            try
            {
                Config.CurrentIndex = Convert.ToInt32(dataGridViewProperty["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this, this, Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                PropertyList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        // Удаление имущества
        private void ButtonDeleteProperty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow(dataGridViewProperty);
            if (index == -1)
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridViewProperty["ID", index].Value.ToString();
                Authorization.DBC.Delete("\"Property_List\"", new Tuple<string, string>("\"PK_Property_List\"", id));
                PropertyList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
        // Добавление проживающего
        private void ButtonAddResident_Click(object sender, EventArgs e)
        {
            if (comboBoxAddApartment.SelectedIndex != -1)
            {
                new AddResident(this, Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])).ShowDialog();
                ResidentList();
            }
            else
            {
                MessageBox.Show("Не заполнено поле Квартира");
            }
        }
        // Редактирование проживающего
        private void ButtonEditResident_Click(object sender, EventArgs e)
        {
            int curRow = GetSelectedRow(dataGridViewResident);
            if (curRow == -1)
            {
                MessageBox.Show("Сначала выберите запись для рекдатирования.");
                return;
            }
            Config.valueFromTableForEdit.Clear();
            foreach (DataGridViewCell cell in dataGridViewResident.Rows[curRow].Cells)
            {
                Config.valueFromTableForEdit.Add(cell.OwningColumn.Name, cell.Value.ToString());
            }
            string nameForm = "AddResident";
            try
            {
                Config.CurrentIndex = Convert.ToInt32(dataGridViewResident["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this, Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                ResidentList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        // Удаление проживающего
        private void ButtonDeleteResident_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow(dataGridViewResident);
            if (index == -1)
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridViewResident["ID", index].Value.ToString();
                Authorization.DBC.Delete("\"List_Resident\"", new Tuple<string, string>("\"PK_List_Resident\"", id));
                ResidentList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        // Добавление 
        private void ButtonAddWorkEquip_Click(object sender, EventArgs e)
        {
            new AddWork_Equipment(this, pkContract).ShowDialog();
            WorkEquipList();
        }
        // Редактирование проживающего
        private void ButtonEditWorkEquip_Click(object sender, EventArgs e)
        {
            int curRow = GetSelectedRow(dataGridViewWorkEquip);
            if (curRow == -1)
            {
                MessageBox.Show("Сначала выберите запись для рекдатирования.");
                return;
            }
            Config.valueFromTableForEdit.Clear();
            foreach (DataGridViewCell cell in dataGridViewWorkEquip.Rows[curRow].Cells)
            {
                Config.valueFromTableForEdit.Add(cell.OwningColumn.Name, cell.Value.ToString());
            }
            string nameForm = "AddWork_Equipment";
            try
            {
                Config.CurrentIndex = Convert.ToInt32(dataGridViewWorkEquip["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this, pkContract) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                WorkEquipList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        // Удаление 
        private void ButtonDeleteWorkEquip_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow(dataGridViewWorkEquip);
            if (index == -1)
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridViewWorkEquip["ID", index].Value.ToString();
                Authorization.DBC.Delete("\"Work_Equipment\"", new Tuple<string, string>("\"PK_Work_Equipment\"", id));
                WorkEquipList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }
    }
}
