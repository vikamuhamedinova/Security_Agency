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
                    if (row["Position_ID"].ToString() != "1") //если не сотрудник отдела по работе с клиентами
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
                Authorization.DBC.Select(tables, where, tableView: dataGridViewProperty,
                values: new Dictionary<string, string>()
                {
                    ["\"Property_List\".\"PK_Property_List\""] = "\"ID\"",
                    ["\"Property_List\".\"PK_Apartment\""] = "\"Адрес\"",
                    ["\"Property_List\".\"PK_Property\""] = "\"Наименование\"",
                    ["\"Property\".\"Property_Cost\""] = "\"Стоимость\""
                }
                );
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
                Authorization.DBC.Select(tables, where, tableView: dataGridViewResident,
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        private void AddContract_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddContract.Text = "Сохранить";
                maskedTextBoxContractIdInput.Text = Config.valueFromTableForEdit["Номер договора"];
                dateTimeInputContract.Text = Config.valueFromTableForEdit["Дата заключения"];
                comboBoxAddClient.SelectedIndex = comboBoxAddClient.FindStringExact(Config.valueFromTableForEdit["Клиент"]);
                comboBoxAddApartment.SelectedIndex = comboBoxAddApartment.FindStringExact(Config.valueFromTableForEdit["Квартира"]);
                comboBoxAddEmployee.SelectedIndex = comboBoxAddEmployee.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                PropertyList();
                ResidentList();
            }
            else
            {
                FillForm();
            }
        }
        //
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
                        MessageBox.Show("Карточка сотрудника была обновлена.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Contract\"", vals);
                        MessageBox.Show("Сотрудник добавлен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                this.Close();
            }
        }
        //
        private void ButtonCancelAddContract_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        //
        private void ButtonAddApartment_Click(object sender, EventArgs e)
        {
            new AddApartment().ShowDialog(this);
            UpdateComboBoxies();
        }
        //
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
        //
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
        //
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
        //
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
        //
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
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                ResidentList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }
        }
        //
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
    }
}
