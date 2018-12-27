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
    public partial class AddCall : Form
    {
        private MainForm mainForm;
        private List<int> apartIDs = new List<int>(),
                          emplIDs = new List<int>();
        private string pkCall;

        //
        public AddCall()
        {
            InitializeComponent();
            FillForm();
        }
        //
        public AddCall(MainForm mainForm)
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
            comboBoxApartment.Items.Clear();
            comboBoxEmployee.Items.Clear();
            // И список ключей
            apartIDs.Clear();
            emplIDs.Clear();
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
                    comboBoxApartment.Items.Add(row["Адрес"].ToString());
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
                    comboBoxEmployee.Items.Add(
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
            dateTimeInputDateCall.Text = "01.01.2000";
            maskedTextBoxPickerTimeCall.Text = "00:00";
            maskedTextBoxPickerTimeArrive.Text = "00:00";
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
        //
        private string ConvertToTimeDB(string text)
        {
            return String.Format("TO_TIMESTAMP('{0}', 'HH24:MI')", text);
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
            if (vals["\"Call_Date\""] == "  .  .")
            {
                vals.Remove("\"Call_Date\"");
            }
            if (vals["\"Time_Call\""] == "  :")
            {
                vals.Remove("\"Time_Call\"");
            }
            if (vals["\"Time_Arrive\""] == "  :")
            {
                vals.Remove("\"Time_Arrive\"");
            }
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
            {
                if (key.ToLower().Contains("date"))
                {
                    newDict.Add(key, ConvertToDateDB(vals[key]));

                }
                else if (key.ToLower().Contains("time_call") || key.ToLower().Contains("time_arrive"))
                {
                    newDict.Add(key, ConvertToTimeDB(vals[key]));
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
        public void DetainedPersonList()
        {
            try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Call\"");
                tables.Add("\"Detained_person\"");
                string pkApartment = Convert.ToString(apartIDs[comboBoxApartment.SelectedIndex]);
                Authorization.DBC.SelectDetainedPerson(tables, pkApartment, pkCall,tableView: dataGridViewDetainPers,
                values: new Dictionary<string, string>()
                {
                    ["\"Detained_person\".\"PK_Detained\""] = "\"ID\"",
                    ["\"Detained_person\".\"PK_Apartment\""] = "\"Адрес\"",
                    ["\"Detained_person\".\"Surname\""] = "\"Фамилия\"",
                    ["\"Detained_person\".\"Name\""] = "\"Имя\"",
                    ["\"Detained_person\".\"Middle_Name\""] = "\"Отчество\"",
                    ["\"Detained_person\".\"Passport_ID\""] = "\"Номер паспорта\"",
                    ["\"Detained_person\".\"PK_Call\""] = "\"Вызов\""
                }
                );
                dataGridViewDetainPers.Columns["Адрес"].Visible = false;
                dataGridViewDetainPers.Columns["Вызов"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //
        public void StolenObjectList()
        {
           /* try
            {
                List<string> tables = new List<string>();
                tables.Add("\"Resident\"");
                tables.Add("\"List_Resident\"");
                string where = Convert.ToString(apartIDs[comboBoxApartment.SelectedIndex]);
                Authorization.DBC.Select(tables, where, tableView: dataGridViewStolenObj,
                values: new Dictionary<string, string>()
                {
                    ["\"Property_List\".\"PK_Property_List\""] = "\"ID\"",
                    ["\"Property_List\".\"PK_Apartment\""] = "\"Адрес\"",
                    ["\"Property_List\".\"PK_Property\""] = "\"Наименование\"",
                    ["\"Property\".\"Property_Cost\""] = "\"Стоимость\""
                }
                );
                dataGridViewStolenObj.Columns["Адрес"].Visible = false;
                for (int i = 0; i < dataGridViewStolenObj.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = dataGridViewStolenObj.Rows[i];
                    string pk = row.Cells["Наименование"].Value.ToString();
                    row.Cells["Наименование"].Value = Authorization.DBC.GetNameByFK("\"Property_Name\"", "\"Property\"", pk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }
        //
        private void AddCall_Load(object sender, EventArgs e)
        { 
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddCall.Text = "Сохранить";
                pkCall = Config.valueFromTableForEdit["ID"];
                dateTimeInputDateCall.Text = Config.valueFromTableForEdit["Дата вызова"];
                maskedTextBoxPickerTimeCall.Text = Config.valueFromTableForEdit["Время вызова"];
                maskedTextBoxPickerTimeArrive.Text = Config.valueFromTableForEdit["Время прибытия экипажа"];
                checkBoxFalseCall.Checked = Config.valueFromTableForEdit["Ложный вызов"] == "Да" ? true : false;
                checkBoxHackSign.Checked = Config.valueFromTableForEdit["Был взлом"] == "Да" ? true : false;
                comboBoxApartment.SelectedIndex = comboBoxApartment.FindStringExact(Config.valueFromTableForEdit["Квартира"]);
                comboBoxEmployee.SelectedIndex = comboBoxEmployee.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                DetainedPersonList();
                StolenObjectList();
                tabControl1.Enabled = true;
            }
            else
            {
                FillForm();
                tabControl1.Enabled = false;
            }
        }
        //
        private void ButtonAddCall_Click(object sender, EventArgs e)
        {
            if ((comboBoxApartment.SelectedIndex == -1) ||
                (comboBoxEmployee.SelectedIndex == -1))
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Call_Date\""] = dateTimeInputDateCall.Text,
                    ["\"Time_Call\""] = maskedTextBoxPickerTimeCall.Text,
                    ["\"Time_Arrive\""] = maskedTextBoxPickerTimeArrive.Text,
                    ["\"False_Sign\""] = Convert.ToString(checkBoxFalseCall.Checked),
                    ["\"Hack_Sign\""] = Convert.ToString(checkBoxHackSign.Checked),                   
                    ["\"PK_Apartment\""] = Convert.ToString(apartIDs[comboBoxApartment.SelectedIndex]),
                    ["\"PK_Employee\""] = Convert.ToString(emplIDs[comboBoxEmployee.SelectedIndex])
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Call\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Карточка сотрудника была обновлена.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Call\"", vals);
                        DataTable dataTable = new DataTable();
                        string where = ConvertToDateDB(dateTimeInputDateCall.Text);
                        ///
                        var adapter = Authorization.DBC.SelectPKResident("\"Call\"", where,
                                                                new Dictionary<string, string>()
                                                                {
                                                                    ["\"PK_Call\""] = "ID"
                                                                });
                        ///
                        adapter.Fill(dataTable);
                        DataRow row = dataTable.Rows[0];
                        pkCall = row["ID"].ToString();
                        MessageBox.Show("Сотрудник добавлен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                tabControl1.Enabled = true;
            }
        }
        //
        private void ButtonCancelAddCall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
        //
        private void CheckBoxFalseCall_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFalseCall.Checked)
                checkBoxHackSign.Enabled = false;
            else
                checkBoxHackSign.Enabled = true;
        }
        //
        private void CheckBoxHackSign_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHackSign.Checked)
                checkBoxFalseCall.Enabled = false;
            else
                checkBoxFalseCall.Enabled = true;
        }
        //
        private void ButtonAddDetainPers_Click(object sender, EventArgs e)
        {
            //new AddDetainedPerson(this, pkCall).ShowDialog();
            DetainedPersonList();
        }
        //
        private void ButtonEditDetainPers_Click(object sender, EventArgs e)
        {
            /*int curRow = GetSelectedRow(dataGridViewProperty);
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
            string nameForm = "AddDetainedPerson";
            try
            {
                Config.CurrentIndex = Convert.ToInt32(dataGridViewProperty["ID", curRow].Value.ToString());
                var form = Activator.CreateInstance(Type.GetType("Security_Agency." + nameForm), this, this, Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])) as Form;
                form.Text = "Редактирование";
                form.ShowDialog();
                DetainedPersonList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }*/
        }
        //
        private void ButtonDeleteDetainPers_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                DetainedPersonList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }*/
        }
        //
        private void ButtonAddStolenObj_Click(object sender, EventArgs e)
        {
            //new AddStolenObject(this, Convert.ToString(apartIDs[comboBoxAddApartment.SelectedIndex])).ShowDialog();
            StolenObjectList();
        }
        //
        private void ButtonEditStolenObj_Click(object sender, EventArgs e)
        {
            /*int curRow = GetSelectedRow(dataGridViewResident);
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
                StolenObjectList();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Форма для данного контекста еще не задана");
            }*/
        }

        //
        private void ButtonDeleteStolenObj_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int index = GetSelectedRow(dataGridViewStolenObj);
            if (index == -1)
            {
                MessageBox.Show("Необходимо выбрать строку.");
                return;
            }
            try
            {
                string id = dataGridViewStolenObj["ID", index].Value.ToString();
                Authorization.DBC.Delete("\"List_Resident\"", new Tuple<string, string>("\"PK_List_Resident\"", id));
                StolenObjectList();
                MessageBox.Show("Запись успешно удалена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }*/
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
