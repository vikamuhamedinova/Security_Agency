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

        private void ButtonAddApartment_Click(object sender, EventArgs e)
        {
            new AddApartment().ShowDialog(this);
            UpdateComboBoxies();
        }
    }
}
