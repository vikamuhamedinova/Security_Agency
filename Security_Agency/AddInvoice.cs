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
    public partial class AddInvoice : Form
    {
        private MainForm mainForm;
        private List<int> emplIDs = new List<int>(),
                          contrIDs = new List<int>();

        //
        public AddInvoice()
        {
            InitializeComponent();
            FillForm();
        }
        //
        public AddInvoice(MainForm mainForm)
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
            comboBoxAddContract.Items.Clear();
            comboBoxAddEmployee.Items.Clear();
            // И список ключей
            emplIDs.Clear();
            contrIDs.Clear();
            // Заполняем данными все комбоБоксы
            string currentTable;
            DataTable dataTable = new DataTable();
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
                    if (row["Position_ID"].ToString() != "2") //если не сотрудник отдела по работе с клиентами
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
                currentTable = "\"Contract\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Contract\""] = "ID",
                                                            ["\"Contract_ID\""] = "Номер",
                                                            ["\"PK_Client\""] = "Клиент"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    contrIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    string client = Authorization.DBC.GetNameByFK("\"Surname\" || ' ' || \"Name\" || ' ' || \"Middle_Name\"", "\"Client\"", row["Клиент"].ToString());
                    comboBoxAddContract.Items.Add(
                        row["Номер"].ToString() + " "
                        + client);
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
            maskedTextBoxInvoiceIdInput.Text = "";
            dateTimeInvoiceInput.Text = "01.01.2000";
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
        /*public void PropertyList()
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
        }*/
        //
        /*public void ResidentList()
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
        }*/
        //
        private void AddInvoice_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddInvoice.Text = "Сохранить";
                maskedTextBoxInvoiceIdInput.Text = Config.valueFromTableForEdit["Номер счета"];
                dateTimeInvoiceInput.Text = Config.valueFromTableForEdit["Дата формирования"];
                comboBoxAddContract.SelectedIndex = comboBoxAddContract.FindStringExact(Config.valueFromTableForEdit["Договор"]);
                comboBoxAddEmployee.SelectedIndex = comboBoxAddEmployee.FindStringExact(Config.valueFromTableForEdit["Сотрудник"]);
                //PropertyList();
                //ResidentList();
            }
            else
            {
                FillForm();
            }
        }
        //
        private void ButtonAddInvoice_Click(object sender, EventArgs e)
        {
            /*if ((comboBoxAddClient.SelectedIndex == -1) ||
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
                        MessageBox.Show("Договор добавлен.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
                this.Close();
            }*/
        }
        //
        private void ButtonCancelAddInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
