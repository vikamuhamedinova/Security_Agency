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
    public partial class AddEmployee : Form
    {
        private MainForm mainForm;
        private List<int> posIDs = new List<int>();

        //
        public AddEmployee()
        {
            InitializeComponent();
            FillForm();
        }
        //
        public AddEmployee(MainForm mainForm)
        {
            InitializeComponent();
            FillForm();
            this.mainForm = mainForm;
        }
        // Заполнение формы при старте
        private void FillForm()
        {
            UpdateComboBoxies();
        }
        // Обновление комбоБоксов при страте и добавлении квартир, сотрудников, клиентов
        private void UpdateComboBoxies()
        {
            // Очищаем все комбоБоксы
            comboBoxInputPosition.Items.Clear();
            // И список ключей
            posIDs.Clear();
            // Заполняем данными все комбоБоксы
            // Должности
            string currentTable;
            DataTable dataTable = new DataTable();
            try
            {
                currentTable = "\"Position\"";
                var adapter = Authorization.DBC.Select(currentTable,
                                                        new Dictionary<string, string>()
                                                        {
                                                            ["\"PK_Position\""] = "ID",
                                                            ["\"Position_Title\""] = "Наименование"
                                                        });
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    posIDs.Add(Convert.ToInt32(row["ID"].ToString()));
                    comboBoxInputPosition.Items.Add(row["Наименование"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            dataTable.Clear();
        }
        //
        private void ClearForm()
        {
            textBoxSurnameInput.Text = "";
            textBoxNameInput.Text = "";
            textBoxMiddleNameInput.Text = "";
            maskedtextBoxInputPassID.Text = "";
            maskedTextBoxInputINN.Text = "";
        }
        //
        private string ConvertToStringDB(string text)
        {
            return "'" + text + "'";
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
            var newDict = new Dictionary<string, string>();
            foreach (var key in vals.Keys)
                newDict.Add(key, ConvertToStringDB(vals[key]));
            return newDict;
        }
        //
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            if (Text == "Редактирование")
            {
                UpdateComboBoxies();
                this.buttonAddEmployee.Text = "Сохранить";
                textBoxSurnameInput.Text = Config.valueFromTableForEdit["Фамилия"];
                textBoxNameInput.Text = Config.valueFromTableForEdit["Имя"];
                textBoxMiddleNameInput.Text = Config.valueFromTableForEdit["Отчество"];
                maskedtextBoxInputPassID.Text = Config.valueFromTableForEdit["Номер паспорта"];
                maskedTextBoxInputINN.Text = Config.valueFromTableForEdit["ИНН"];
                comboBoxInputPosition.SelectedIndex = comboBoxInputPosition.FindStringExact(Config.valueFromTableForEdit["Должность"]);
            }
            else
            {
                ClearForm();
                FillForm();
            }
        }
        //
        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            if (textBoxSurnameInput.Text == "" || textBoxNameInput.Text == ""
               || maskedtextBoxInputPassID.Text == "" || maskedTextBoxInputINN.Text == "")
            {
                MessageBox.Show("Не заполнено одно из обязательных полей");
            }
            else
            {
                Dictionary<string, string> vals = new Dictionary<string, string>()
                {
                    ["\"Surname\""] = textBoxSurnameInput.Text,
                    ["\"Name\""] = textBoxNameInput.Text,
                    ["\"Middle_Name\""] = textBoxMiddleNameInput.Text,
                    ["\"Passport_ID\""] = maskedtextBoxInputPassID.Text,
                    ["\"INN\""] = maskedTextBoxInputINN.Text,
                    ["\"PK_Position\""] = Convert.ToString(posIDs[comboBoxInputPosition.SelectedIndex])
                };
                vals = PrepareData(vals);
                try
                {
                    if (Text == "Редактирование")
                    {
                        Authorization.DBC.Update("\"Employee\"", Config.valueFromTableForEdit["ID"], vals);
                        MessageBox.Show("Карточка сотрудника была обновлена.");
                    }
                    else
                    {
                        Authorization.DBC.Insert("\"Employee\"", vals);
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
        private void ButtonCancelAddEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите отменить добавление?", "Отмена добавления",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
